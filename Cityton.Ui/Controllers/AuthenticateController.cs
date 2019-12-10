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

namespace Cityton.Ui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthenticateController : ControllerBase
    {

        private readonly IConfiguration _appSettings;
        private IAuthService _authService;
        private IUserService _userService;

        public AuthenticateController(IConfiguration config, IAuthService authService, IUserService userService)
        {

            _appSettings = config;
            _authService = authService;
            _userService = userService;

        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO data)
        {

            //ModelState.IsValid

            var user = await _authService.Authenticate(data.Email, data.Password);

            if (user == null) { return Unauthorized(); }

            user.CreateToken(_appSettings);

            await _userService.Update(user);

            return Ok(new
            {
                Id = user.Id,
                Username = user.Username,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Picture = user.Picture,
                Role = user.Role.ToString(),
                Token = user.Token
            });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]RegisterDTO data)
        {

            //var validator = new RegisterDtoValidator(_userService);
            //var results = await validator.ValidateAsync(data);
            //results.AddToModelState(ModelState, "RegisterDTO");

            //if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);

            //if(_userService.GetByEmail(data.Email)) { return this.BadRequest("lol"); }

            User newUser = data.ToUser();
            newUser.CreateToken(_appSettings);

            User user = await _authService.Register(newUser, data.Password);

            return Ok(new
            {
                Id = user.Id,
                Username = user.Username,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Picture = user.Picture,
                Role = user.Role.ToString(),
				Token = user.Token
            });
        }

    }
}