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
        [HttpPost("create")]
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

    }
}