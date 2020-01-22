using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cityton.Data.DTOs;
using Cityton.Data;
using System.Security.Claims;
using System.Text;
using Cityton.Service;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using FluentValidation.AspNetCore;
using Cityton.Service.Validators.DTOs;
using Cityton.Data.Models;
using System.IO;
using Cityton.Data.Mapper;
using FluentValidation.Results;
using Cityton.Data.Common;

namespace Cityton.Ui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [Produces("application/json")]
    public class GroupController : ControllerBase
    {

        private readonly IConfiguration _appSettings;
        private IGroupService _groupService;
        private IUserService _userService;
        private ICompanyService _companyService;

        public GroupController(
            IConfiguration config,
            IGroupService groupService,
            IUserService userService,
            ICompanyService companyService
        )
        {
            _appSettings = config;
            _groupService = groupService;
            _userService = userService;
            _companyService = companyService;

        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {

            List<Group> groups = await this._groupService.GetAll();

            int connectedUserId = int.Parse(User.Identity.Name);

            User connectedUser = await this._userService.Get(connectedUserId);

            Company company = await this._companyService.Get(connectedUser.CompanyId);

            return Ok(new { maxGroupSize = company.MaxGroupSize, groups = groups.ToDTO(connectedUserId) });

        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            Group group = await this._groupService.Get(id);

            if (group == null) return BadRequest();

            int connectedUserId = int.Parse(User.Identity.Name);

            User connectedUser = await this._userService.Get(connectedUserId);

            Company company = await this._companyService.Get(connectedUser.CompanyId);

            return Ok(new { maxGroupSize = company.MaxGroupSize, groupDetails = group.ToGroupDetailsDTO() });

        }

        [Authorized(Role.Member)]
        [HttpPost("membershipRequest")]
        public async Task<IActionResult> MembershipRequest([FromBody] int groupId)
        {

            Group group = await this._groupService.Get(groupId);

            if (group == null) return BadRequest();

            User connectedUser = await this._userService.Get(int.Parse(User.Identity.Name));

            bool isAccepted = await this._groupService.IsAccepted(connectedUser.Id);

            if (isAccepted) return BadRequest("A user can't send membership request if he is already accepted in a group !");

            ValidationResult result = await this._groupService.MembershipRequest(groupId, connectedUser);

            if (result != null)
            {
                result.AddToModelState(ModelState, "MembershipRequest");
                return this.BadRequest(this.ModelState);
            }

            return Ok(true);
        }

        [Authorized(Role.Member)]
        [HttpPost("acceptRequest")]
        public async Task<IActionResult> AcceptRequest([FromBody]int requestId)
        {

            ParticipantGroup participantGroup = await this._groupService.GetRequest(requestId);

            if (participantGroup == null) return BadRequest("The request id is invalid");

            int connectedUserId = int.Parse(User.Identity.Name);

            User creator = await this._groupService.GetCreator(participantGroup.BelongingGroupId);

            if (creator.Id != connectedUserId) return BadRequest("You have to be the creator of the group !");

            await this._groupService.AcceptRequest(participantGroup);

            return Ok(true);

        }

        [Authorized(Role.Member)]
        [HttpDelete("declineRequest/{requestId}")]
        public async Task<IActionResult> DeclineRequest(int requestId)
        {

            ParticipantGroup participantGroup = await this._groupService.GetRequest(requestId);

            if (participantGroup == null) return BadRequest();

            if (participantGroup.Status == Status.Accepted) return BadRequest("Can't decline someone who is already in the group");

            await this._groupService.DeleteRequest(participantGroup);

            return Ok(true);

        }

        [Authorized(Role.Member)]
        [HttpDelete("leaveGroup/{requestId}")]
        public async Task<IActionResult> LeaveGroup(int requestId)
        {

            ParticipantGroup participantGroup = await this._groupService.GetRequest(requestId);

            if (participantGroup == null) return BadRequest();
            if (participantGroup.Status != Status.Accepted) return BadRequest("Must be an accepted request !");

            int connectedUserId = int.Parse(User.Identity.Name);
            if (participantGroup.UserId != connectedUserId) return BadRequest("Current user is different from request user");

            await this._groupService.DeleteRequest(participantGroup);

            return Ok(requestId);

        }

        [Authorized(Role.Member)]
        [HttpPost("createByMember/")]
        public async Task<IActionResult> Create(Group newGroupByMember)
        {
            Group group = await this._groupService.GetByName(newGroupByMember.Name);

            if (group != null) return BadRequest("This name already exist");

            int connectedUserId = int.Parse(User.Identity.Name);
            ParticipantGroup requestAccepted = await this._groupService.GetRequestAcceptedByUserId(connectedUserId);
            if (requestAccepted != null) return BadRequest("you are already in a group !");

            User connectedUser = await this._userService.Get(int.Parse(User.Identity.Name));

            int groupId = await this._groupService.Create(newGroupByMember, connectedUser);

            return Ok(groupId);

        }

        [Authorized(Role.Admin)]
        [HttpPost("createByAdmin/")]
        public async Task<IActionResult> Create(GroupByAdmin newGroupByAdmin)
        {

            GroupByAdminValidator validator = new GroupByAdminValidator(this._groupService);
            ValidationResult results = await validator.ValidateAsync(newGroupByAdmin);

            results.AddToModelState(ModelState, "GroupByAdmin");

            if (!ModelState.IsValid) return BadRequest(this.ModelState);

            int groupId = await this._groupService.CreateByAdmin(newGroupByAdmin);

            return Ok(groupId);

        }

        [Authorized(Role.Member, Role.Admin)]
        [HttpGet("existName/{name}")]
        public async Task<IActionResult> ExistName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return BadRequest("");

            return Ok(await this._groupService.ExistName(name));
        }

        [Authorized(Role.Admin)]
        [HttpGet("searchGroups")]
        public async Task<IActionResult> SearchGroups(string toSearch)
        {

            if (string.IsNullOrEmpty(toSearch)) return BadRequest();

            List<Group> groups = await _groupService.Search(toSearch);

            int connectedUserId = int.Parse(User.Identity.Name);

            return Ok(groups.ToDTO(connectedUserId));
        }

        [Authorized(Role.Admin)]
        [HttpDelete("{groupId}")]
        public async Task<IActionResult> Delete(int groupId)
        {

            Group group = await this._groupService.Get(groupId);

            if (group == null) return BadRequest("No group with this id !");

            await this._groupService.Delete(group);

            return Ok();
        }

        [Authorized(Role.Admin)]
        [HttpGet("getMinorGroups")]
        public async Task<IActionResult> GetMinorGroups()
        {

            int connectedUserId = int.Parse(User.Identity.Name);

            User connectedUser = await this._userService.Get(connectedUserId);

            List<Group> groups = await this._groupService.GetMinorGroups(connectedUser.CompanyId);

            return Ok(groups.ToDTO(connectedUserId));
        }

        [Authorized(Role.Member, Role.Admin)]
        [HttpGet("getInfosEdit/{groupId}")]
        public async Task<IActionResult> GetInfosEdit(int groupId)
        {
            
            Group group = await this._groupService.GetWithRequestUser(groupId);
            
            return Ok(group.ToGroupInfosEdit());
        }

        [Authorized(Role.Member, Role.Admin)]
        [HttpPost("edit")]
        public async Task<IActionResult> Edit(GroupInfosEdit groupInfo)
        {

            int connectedUserId = int.Parse(User.Identity.Name);

            User connectedUser = await this._userService.GetWithRequest(connectedUserId);

            if (connectedUser.Role != Role.Admin && (connectedUser.Role == Role.Member && !connectedUser.ParticipantGroups.Any(pg => pg.IsCreator))) return BadRequest("You are not an admin or the creator of this group !");
            
            // Validator

            // Group group = await this._groupService.Edit(groupInfo);

            await this._groupService.Edit(groupInfo);
            
            return Ok();
        }

    }
}