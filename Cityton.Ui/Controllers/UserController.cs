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

            //foreach (var user in users)
            //{
            //    PhysicalFileResult file = this._userService.GetProfilePicture(user.Id);
            //    searchedUsers.Add(new SearchUserDTO
            //    {
            //        Id = user.Id,
            //        Username = user.Username,
            //        Picture = file != null ? file.FileName : null,
            //        Role = user.Role
            //    });
            //}

            return Ok(users);

        }

        // [HttpPut("update/{id}")]
        // public void Update(int id, [FromBody] UserDTO userToUpdate)
        // {

        //     User userInDb = await _userService.Get(id);

        //     if (userInDb == null)
        //     {
        //        return NotFound();
        //     }

        //     //validator sur userToUpdate

        //     User user = userToUpdate.ToUser();

        //     if (string.IsNullOrEmpty(password))
        //     {
        //        user.PasswordHash = userInDb.PasswordHash;
        //        user.PasswordSalt  = userInDb.PasswordSalt;
        //     } 
        //     else {
        //        user.CreatePasswordHash(password);
        //     }

        //     user.CreateToken(_appSettings);

        //     //validator sur user
        //     Console.WriteLine(user.Picture);

        //     userInDb.Username = user.Username;
        //     userInDb.PhoneNumber = user.PhoneNumber;
        //     userInDb.Email = user.Email;
        //     userInDb.Picture = user.Picture;
        //     userInDb.PasswordHash = user.PasswordHash;
        //     userInDb.PasswordSalt = user.PasswordSalt;
        //     userInDb.Token = user.Token;

        //     await _userService.Update(userInDb);
        //     Console.WriteLine(userInDb.Picture);
        //     return Ok(userInDb);
        // }

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