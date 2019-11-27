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
    public class UserController : ControllerBase
    {

        private readonly IConfiguration _appSettings;
        private IUserService _userService;

        public UserController(IConfiguration config, IUserService userService)
        {
            _appSettings = config;
            _userService = userService;

        }

        [HttpPut("test/{id}")]
        public string Test(int id, UserDTO userToUpdate)
        {
            return "OKOKOKOK";
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, UserDTO userToUpdate, string password)
        {
            if (id != userToUpdate.Id)
            {
                return BadRequest();
            }
            
            User userInDb = await _userService.Get(id);

            if (userInDb == null)
            {
                return NotFound();
            }

            //validator sur userToUpdate

            User user = userToUpdate.ToUser();

            if (string.IsNullOrEmpty(password))
            {
                user.PasswordHash = userInDb.PasswordHash;
                user.PasswordSalt  = userInDb.PasswordSalt;
            } 
            else {
                user.CreatePasswordHash(password);
            }

            user.CreateToken(_appSettings);

            //validator sur user

            userInDb.Username = user.Username;
            userInDb.PhoneNumber = user.PhoneNumber;
            userInDb.Email = user.Email;
            userInDb.Picture = user.Picture;
            userInDb.PasswordHash = user.PasswordHash;
            userInDb.PasswordSalt = user.PasswordSalt;
            userInDb.Token = user.Token;

            await _userService.Update(userInDb);

            User testUser = await _userService.Get(id);

            return Ok(testUser);
        }

    }
}