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

        public ChallengeController(
            IConfiguration config,
            IChallengeService challengeService
        )
        {
            _appSettings = config;
            _challengeService = challengeService;
        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {

            IEnumerable<Challenge> challenges = await this._challengeService.GetAll();

            // int connectedUserId = int.Parse(User.Identity.Name);

            // User connectedUser = await this._userService.Get(connectedUserId);

            // Company company = await this._companyService.Get(connectedUser.CompanyId);

            // return Ok(new { maxGroupSize = company.MaxGroupSize, groups = groups.ToDTO(connectedUserId) });

            return Ok();

        }

    }
}