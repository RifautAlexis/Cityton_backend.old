using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Cityton.Data.DTOs;
using Cityton.Service;
using Microsoft.AspNetCore.Http;
using Cityton.Data.Models;
using Cityton.Data.Mapper;
using System.Web;
using System.Security.Claims;
using System.Linq;
using Cityton.Data.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Caching.Memory;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using Cityton.Data;
using System.Collections.Generic;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {

        private IChatService _chatService;
        private IHttpContextAccessor _contextAccessor;

        // private static IMemoryCache usersConnectedToChat;
        private static Dictionary<string, int> usersConnectedToChat = new Dictionary<string, int>();
        private readonly IConfiguration _appSettings;

        public ChatHub(IChatService chatService, IHttpContextAccessor contextAccessor, IConfiguration config)
        {
            this._chatService = chatService;
            this._contextAccessor = contextAccessor;
            // this._usersConnectedToChat = memoryCache;
            _appSettings = config;
        }

        public override Task OnConnectedAsync()
        {
            string jwt = this._contextAccessor.HttpContext.Request.Query["access_token"];

            if (this.IsAuthorized(jwt))
            {
                this.decodeToken(jwt, out int userId, out Role role);

                if (usersConnectedToChat.ContainsKey(Context.ConnectionId))
                {

                    Context.Abort();
                    return Task.FromException(new Exception("A connection already exist, both are removed"));


                }

                usersConnectedToChat.Add(Context.ConnectionId, userId);
                return base.OnConnectedAsync();

            }

            if (usersConnectedToChat.ContainsKey(Context.ConnectionId)) usersConnectedToChat.Remove(Context.ConnectionId); // token expired and trying to reconnect
            Context.Abort();
            return Task.FromException(new Exception("You are not authorized"));
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {

            usersConnectedToChat.Remove(Context.ConnectionId);

            Context.Abort();
            return base.OnDisconnectedAsync(exception);
        }

        public async Task NewMessage(string message, int discussionId)
        {

            if (!usersConnectedToChat.TryGetValue(Context.ConnectionId, out int connectedUSerId))
            {
                Context.Abort();
            }

            Message messageAdded = await this._chatService.NewMessage(message, connectedUSerId, discussionId);
            Discussion thread = await this._chatService.GetDiscussion(discussionId);

            await Clients.Group(thread.Name).SendAsync("messageReceived", messageAdded.ToDTO());
        }

        /* ****************************** */

        public async Task AddToGroup()
        {
            string currentConnectionId = Context.ConnectionId;
            // if (usersConnectedToChat.ContainsKey(currentConnectionId))
            // {
                IEnumerable<Discussion> discussions = await this._chatService.GetThreads(usersConnectedToChat.GetValueOrDefault(currentConnectionId));

                await discussions
                    .ToList()
                    .ForEachAsync(d => Groups.AddToGroupAsync(Context.ConnectionId, d.Name));

                return;
            // }
            // else
            // {
            //     await Task.FromException(new Exception("You ConnectionId is not authorized"));
            // }
        }

        public async Task RemoveFromGroup(string discussionName)
        {
            string currentConnectionId = Context.ConnectionId;
            // if (usersConnectedToChat.ContainsKey(currentConnectionId))
            // {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, discussionName);

                await Task.FromResult(true);
            // }
            // else
            // {
            //     await Task.FromException(new Exception("You ConnectionId is not authorized"));
            // }
        }

        public async Task RemoveFromAllGroups()
        {
            string currentConnectionId = Context.ConnectionId;
            // if (usersConnectedToChat.ContainsKey(currentConnectionId))
            // {
                IEnumerable<Discussion> discussions = await this._chatService.GetThreads(usersConnectedToChat.GetValueOrDefault(currentConnectionId));
                await discussions
                    .ToList()
                    .ForEachAsync(d => Groups.RemoveFromGroupAsync(Context.ConnectionId, d.Name));

                return;
            // }
            // else
            // {
            //     await Task.FromException(new Exception("You ConnectionId is not authorized"));
            // }
        }

        /* ****************************** */

        private bool IsAuthorized(string jwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var appSettingsSection = this._appSettings.GetSection("Settings");
            var appSettings = appSettingsSection.Get<Settings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };

            SecurityToken validatedToken;
            try
            {
                var claims = tokenHandler.ValidateToken(jwt, validationParameters, out validatedToken);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void decodeToken(string jwt, out int userId, out Role role)
        {
            var handler = new JwtSecurityTokenHandler();
            JwtSecurityToken tokenDecoded = handler.ReadJwtToken(jwt);

            userId = Int32.Parse(tokenDecoded.Claims.First(claim => claim.Type == "unique_name").Value);
            role = (Role)Enum.Parse(typeof(Role), tokenDecoded.Claims.First(claim => claim.Type == "role").Value);
        }
    }
}