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
    public class ChallengeController : ControllerBase
    {

        private readonly IConfiguration _appSettings;
        private IChallengeService _challengeService;
        private IUserService _userService;

        public ChallengeController(
            IConfiguration config,
            IChallengeService challengeService,
            IUserService userService
        )
        {
            _appSettings = config;
            _challengeService = challengeService;
            _userService = userService;
        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {

            IEnumerable<Challenge> challenges = await this._challengeService.GetAllAccepted_Author_Achivements();

            int connectedUserId = int.Parse(User.Identity.Name);

            User connectedUser = await this._userService.Get(connectedUserId);

            List<User> users = await this._userService.GetAll();
            double nbTotalUsers = users.Count();

            return Ok(challenges.ToDTO(connectedUser, nbTotalUsers));

        }

        [Authorized(Role.Member, Role.Admin)]
        [HttpGet("existName/{name}")]
        public async Task<IActionResult> ExistName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return BadRequest("");

            return Ok(await this._challengeService.ExistName(name));
        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpPost("")]
        public async Task<IActionResult> Create(ChallengeCreate newChallenge)
        {
            ChallengeCreateValidator validator = new ChallengeCreateValidator(this._challengeService);
            ValidationResult results = await validator.ValidateAsync(newChallenge);

            results.AddToModelState(ModelState, "ChallengeCreate");

            if (!ModelState.IsValid) return BadRequest(this.ModelState);

            int connectedUserId = int.Parse(User.Identity.Name);
            User connectedUser = await this._userService.Get(int.Parse(User.Identity.Name));

            int ChallengeId = await this._challengeService.Create(newChallenge, connectedUser);

            return Ok(ChallengeId);

        }

        [Authorized(Role.Admin)]
        [HttpGet("getAllWaiting")]
        public async Task<IActionResult> GetAllWaiting()
        {

            IEnumerable<Challenge> challenges = await this._challengeService.GetAllWaiting_Author();

            return Ok(challenges.ToDTO(null, null));
        }

        [Authorized(Role.Admin)]
        [HttpGet("search")]
        public async Task<IActionResult> Search(string toSearch)
        {

            if (string.IsNullOrEmpty(toSearch)) return BadRequest();

            List<Challenge> challenges = await _challengeService.Search(toSearch);

            int connectedUserId = int.Parse(User.Identity.Name);

            return Ok(challenges.ToDTO(null, null));
        }

        [Authorized(Role.Admin)]
        [HttpPost("edit")]
        public async Task<IActionResult> Edit(ChallengeEdit challengeEdit)
        {
            
            ChallengeEditValidator validator = new ChallengeEditValidator(this._challengeService);
            ValidationResult results = await validator.ValidateAsync(challengeEdit);

            results.AddToModelState(ModelState, "ChallengeEdit");

            if (!ModelState.IsValid) return BadRequest(this.ModelState);

            int connectedUserId = int.Parse(User.Identity.Name);

            User connectedUser = await this._userService.GetWithRequest(connectedUserId);

            if (connectedUser.Role != Role.Admin && (connectedUser.Role == Role.Member && !connectedUser.ParticipantGroups.Any(pg => pg.IsCreator))) return BadRequest("You are not an admin or the creator of this group !");

            await this._challengeService.Edit(challengeEdit);
            
            return Ok();
        }

        [Authorized(Role.Admin)]
        [HttpPut("validate/{id}")]
        public async Task<IActionResult> Validate(int id)
        {

            Challenge challenge = await this._challengeService.Get(id);

            if(challenge == null) return BadRequest("No challenge with this id");

            challenge.Status = Status.Accepted;

            await _challengeService.Update(challenge);

            return Ok();
        }

        [Authorized(Role.Admin)]
        [HttpDelete("{challengeId}")]
        public async Task<IActionResult> Delete(int challengeId)
        {

            Challenge challenge = await this._challengeService.Get(challengeId);

            if (challenge == null) return BadRequest("No challenge with this id !");

            await this._challengeService.Delete(challenge);

            return Ok();
        }

    }
}