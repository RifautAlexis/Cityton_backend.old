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

            IEnumerable<Message> messages = await this._chatService.GetByDiscussionIdWithAuthor_Media(discussionId);

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
        [HttpGet("getThread/{threadId}")]
        public async Task<IActionResult> GetThread(int threadId)
        {
            Discussion thread = await this._chatService.GetThread(threadId);

            return Ok(thread.ToThread());

        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpGet("getChallenges/{discussionId}")]
        public async Task<IActionResult> GetChallengesChat(int discussionId)
        {
            IEnumerable<ChallengeChat> challenges = await this._chatService.GetChallengesGivenFromGroup(discussionId);

            return Ok(challenges);

        }

        [Authorized(Role.Checker, Role.Admin)]
        [HttpPut("updateStatusChallenge/{challengeGivenId}")]
        public async Task<IActionResult> UpdateStatusChallengeGiven(int challengeGivenId, [FromBody] StatusChallenge newStatus)
        {

            ChallengeGiven challengeGiven = await this._chatService.GetChallengeGiven(challengeGivenId);

            if (challengeGiven == null) return BadRequest("No challenge with this id");

            challengeGiven.Status = newStatus;

            await _chatService.UpdateChallengeGiven(challengeGiven);

            return Ok();
        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpPut("renameThread/{threadId}")]
        public async Task<IActionResult> RenameThread(int threadId, [FromBody] string newName)
        {

            Discussion discussion = await this._chatService.GetDiscussion(threadId);

            if (discussion == null) return BadRequest("No discussion with this id");

            discussion.Name = newName;

            await _chatService.UpdateDiscussion(discussion);

            return Ok();
        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        [HttpGet("existThreadName/{newName}")]
        public async Task<IActionResult> ExistThreadName(string newName)
        {

            Discussion discussion = await this._chatService.GetDiscussionByName(newName);

            return Ok(discussion == null);
        }
    }
}