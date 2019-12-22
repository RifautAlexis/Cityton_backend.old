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

        public GroupController(IConfiguration config, IGroupService groupService)
        {
            _appSettings = config;
            _groupService = groupService;

        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {

            List<Group> groups = await this._groupService.GetAll();

            return Ok(groups.ToDTO());
        }

        [HttpPost("membershipRequest")]
        public async Task<IActionResult> MembershipRequest([FromBody] int groupId)
        {

            Group group = await this._groupService.Get(groupId);

            if (group == null) return BadRequest();

            // await this._groupService.;

            return Ok();
        }

    }
}