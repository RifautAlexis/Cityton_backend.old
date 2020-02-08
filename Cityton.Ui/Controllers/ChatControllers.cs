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
    public class ChatController : ControllerBase
    {

        private readonly IConfiguration _appSettings;
        private IChatService _chatService;
        private IUserService _userService;

        public ChatController(
            IConfiguration config,
            IChatService chatService,
            IUserService userService
        )
        {
            _appSettings = config;
            _chatService = chatService;
            _userService = userService;
        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpGet("getMessages")]
        public async Task<IActionResult> GetMessages()
        {
            List<MessageDTO> messages = new List<MessageDTO>();
            messages.Add(new MessageDTO {Id = 1, Content = "Bonjour", Author = new UserMinimal {Id = 1, Username = "user01"}, CreatedAt = DateTime.Now, DiscussionId = 1});
            messages.Add(new MessageDTO {Id = 2, Content = "Coucou toi", Author = new UserMinimal {Id = 2, Username = "user02"}, CreatedAt = DateTime.Now, DiscussionId = 1});
            messages.Add(new MessageDTO {Id = 3, Content = "Comment tu vas ?", Author = new UserMinimal {Id = 1, Username = "user01"}, CreatedAt = DateTime.Now, DiscussionId = 1});
            messages.Add(new MessageDTO {Id = 4, Content = "Bien et toi ?", Author = new UserMinimal {Id = 2, Username = "user02"}, CreatedAt = DateTime.Now, DiscussionId = 1});
            messages.Add(new MessageDTO {Id = 5, Content = "Oui, ça va très bien :D", Author = new UserMinimal {Id = 1, Username = "user01"}, CreatedAt = DateTime.Now, DiscussionId = 1});
            
            return Ok(messages);

        }

    }
}