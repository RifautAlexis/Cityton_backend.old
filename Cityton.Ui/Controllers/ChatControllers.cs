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
        [HttpGet("getMessages/{discussionId}")]
        public async Task<IActionResult> GetMessages(int discussionId)
        {

            IEnumerable<Message> messages = await this._chatService.GetByDiscussionIdWithAuthor(discussionId);
            
            return Ok(messages.ToDTO());

        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpGet("getMessage/{messageId}")]
        public async Task<IActionResult> GetMessage(int messageId)
        {

            Message message = await this._chatService.GetMessage(messageId);
            
            return Ok(message.ToDTO());

        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpGet("getThreads")]
        public async Task<IActionResult> GetThreads()
        {
            int currentUserId = Int32.Parse(User.Identity.Name);

            IEnumerable<Discussion> threads = await this._chatService.GetThreads(currentUserId);
            
            return Ok(threads.ToThreads());

        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpGet("getChallenges/{discussionId}")]
        public async Task<IActionResult> GetChallenges(int discussionId)
        {
            IEnumerable<Challenge> challenges = await this._chatService.GetChallengesGivenFromGroup(discussionId);
            
            return Ok(challenges);

        }

    }
}