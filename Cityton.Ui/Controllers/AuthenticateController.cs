using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cityton.Data.DTOs;
using System.Security.Claims;
using System.Text;
using Cityton.Service;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using FluentValidation.AspNetCore;
using Cityton.Service.Validators.DTOs;

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

            if (user != null) { return Unauthorized(); }
            
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.GetValue<string>("JWT:Secret"));
            
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim("PHONE", user.PhoneNumber),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim("PICTURE", user.Picture),
                    new Claim("ROLE", user.Role.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            user.Token = tokenString;

            _userService.Update(user);

            return Ok(new
            {
                Id = user.Id,
                Username = user.Username,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Role = user.Role.ToString(),
                Token = tokenString
            });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]RegisterDTO data)
        {

            var validator = new RegisterDtoValidator();
            var results = await validator.ValidateAsync(data);
            results.AddToModelState(ModelState, "RegisterDTO");

            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);


            try
            {
                // create user
                _userService.Create(user, data.Password);
                return Ok();
            }
            catch (AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }

    }
}