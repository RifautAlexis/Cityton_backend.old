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

        [HttpGet("searchUser")]
        public async Task<IActionResult> SearchUser(string sl, string q = null)
        {

            if (string.IsNullOrEmpty(sl))
            {
                return BadRequest();
            }

            List<User> users = await _userService.Search(sl, q);

            List<SearchUserDTO> searchedUsers = new List<SearchUserDTO>();

            return Ok(users);

        }

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



    }
}