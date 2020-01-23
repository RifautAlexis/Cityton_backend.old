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
using Cityton.Data.Mapper;
using System.IO;
using Cityton.Data.Common;

namespace Cityton.Ui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {

        private readonly IConfiguration _appSettings;
        private IUserService _userService;

        public UserController(IConfiguration config, IUserService userService)
        {
            _appSettings = config;
            _userService = userService;

        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(int userId)
        {
            if (userId < 1) return BadRequest();

            User user = await this._userService.GetToTransformInDTO(userId);

            if (user == null) return BadRequest();

            return Ok(user.ToDTO());
        }


        [Authorized(Role.Admin)]
        [HttpGet("searchUser")]
        public async Task<IActionResult> SearchUser(string sl, string q = null)
        {

            if (string.IsNullOrEmpty(sl))
            {
                return BadRequest();
            }

            List<User> users = await _userService.Search(sl, q);

            return Ok(users);

        }


        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UserUpdateDTO userToUpdate)
        {

            var validator = new UserUpdateDTOValidator();
            var results = await validator.ValidateAsync(userToUpdate);
            results.AddToModelState(ModelState, "UserUpdateDTO");

            if (!this.ModelState.IsValid) return this.BadRequest(this.ModelState);

            if (id != userToUpdate.Id) return BadRequest();

            UserDTO user = await _userService.Update(userToUpdate);

            return Ok(user);
        }


        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpPut("uploadPicture/{userId}")]
        public async Task<IActionResult> UploadPicture(int userId, IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Please select profile picture");

            string pictureURL = await this._userService.UploadProfilePicture(userId, file);

            return Ok(pictureURL);
        }

        // [HttpGet("getProfilePicture/{userId}")]
        // public async Task<IActionResult> GetProfilePicture(int userId)
        // {
        //     //PhysicalFileResult profilepicture = this._userService.GetProfilePicture(userId);

        //     //if (profilepicture == null)
        //     //{
        //     //    return BadRequest();
        //     //}

        //     //return profilepicture;

        //     return Ok(this._userService.GetProfilePicture(userId));

        // }

        [HttpGet("existEmail/{email}")]
        [AllowAnonymous]
        public async Task<IActionResult> ExistEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return BadRequest("");

            return Ok(await this._userService.ExistEmail(email));
        }

        [HttpGet("existPhoneNumber/{phoneNumber}")]
        [AllowAnonymous]
        public async Task<IActionResult> ExistPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return BadRequest("");

            return Ok(await this._userService.ExistPhoneNumber(phoneNumber));
        }

        [HttpGet("existUsername/{username}")]
        [AllowAnonymous]
        public async Task<IActionResult> ExistUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
                return BadRequest("");

            return Ok(await this._userService.ExistUsername(username));
        }


        [Authorized(Role.Admin)]
        [HttpDelete("{userId}")]
        public async Task<IActionResult> Delete(int userId)
        {
            if (userId > 0) return BadRequest("");

            User user = await this._userService.Get(userId);

            if (user == null) return BadRequest("");

            await this._userService.Delete(user);

            return Ok();
        }
        
        [Authorized(Role.Member, Role.Admin)]
        [HttpGet("getUsersWithoutGroup/{toSearch}")]
        [HttpGet("getUsersWithoutGroup")]
        public async Task<IActionResult> GetUsersWithoutGroup(string toSearch = "")
        {
            
            List<User> users = await this._userService.GetUsersWithoutGroup(toSearch);

            return Ok(users.ToMinimalDTO());
        }
    }
}