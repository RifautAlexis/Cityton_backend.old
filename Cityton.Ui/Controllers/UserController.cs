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
            Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAA");
            Console.WriteLine(q);
            Console.WriteLine(sl);
            Console.WriteLine("ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ");
            List<User> user = await _userService.Search(sl, q);

            return Ok(user);

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

            return Ok(userInDb);
        }

        [HttpPut("uploadPicture/{id}")]
        public async Task<IActionResult> UploadPicture(int userId, IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Please select profile picture");

            var folderName = Path.Combine("Resources", "ProfilePics");
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), folderName);

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            var uniqueFileName = $"{userId}_profilepic.png";

            var dbPath = Path.Combine(folderName, uniqueFileName);

            using (var fileStream = new FileStream(Path.Combine(filePath, uniqueFileName), FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return Ok( new {
                path = dbPath
            });
        }



    }
}