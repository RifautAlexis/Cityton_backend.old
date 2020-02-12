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

namespace SignalRChat.Hubs
{

    // Avoir un dictionaire => override onConnect pour avoir le userId => de là mettre le userId dans dictionnaire avec connectionId
    
    // [Authorize(JwtBearerDefaults.AuthenticationScheme)]
    public class ChatHub : Hub
    {

        private IChatService _chatService;
        private IHttpContextAccessor _contextAccessor;

        public ChatHub(IChatService chatService, IHttpContextAccessor contextAccessor)
        {
            this._chatService = chatService;
            this._contextAccessor = contextAccessor;
        }

        // [Authorized(Role.Member, Role.Checker, Role.Admin)]
        public async Task NewMessage(string message, int discussionId)
        {
            System.Console.WriteLine("LOLOLOLOLOLOL");
            System.Console.WriteLine(Context.GetHttpContext().Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value); // TryGetValue("Authorization", out var authorizationValues));
            System.Console.WriteLine(Context.UserIdentifier);
            System.Console.WriteLine(Context.User.Identity.Name);
            System.Console.WriteLine(this._contextAccessor.HttpContext.User.Identity.Name);
            System.Console.WriteLine("POPOPOPOPOPOPOOPOPOPO");



            int connectedUSerId = int.Parse(this._contextAccessor.HttpContext.User.Identity.Name);
            int messageAddedId = await this._chatService.NewMessage(message, connectedUSerId, discussionId);

            Message messageAdded = await this._chatService.GetMessage(messageAddedId);

            // System.Console.WriteLine("AAAAAAAAAAA " + message + " ZZZZZZZZZZZZZZ");

            await Clients.All.SendAsync("messageReceived", messageAdded.ToDTO());

            // await Clients.All.SendAsync("messageReceived", new MessageDTO { Id = 0, Content = message, Author = new UserMinimal { Id = 0, Username = "userTest" }, CreatedAt = DateTime.Now, DiscussionId = 0 });
        }
    }
}