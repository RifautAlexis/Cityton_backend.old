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

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {

        private IChatService _chatService;
        private IHttpContextAccessor _contextAccessor;

        public ChatHub(IChatService chatService, IHttpContextAccessor contextAccessor)
        {
            this._chatService = chatService;
            this._contextAccessor = contextAccessor;
        }

        [Authorized(Role.Member, Role.Checker, Role.Admin)]
        public async Task NewMessage(string message, int discussionId)
        {

            this.NameUSerID.GetUserId(this._contextAccessor.HttpContext);
            System.Console.WriteLine("AAAAAAAAAAA");
            System.Console.WriteLine(message);
            System.Console.WriteLine(discussionId);
            System.Console.WriteLine(this._contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier));
            if(this._contextAccessor.HttpContext.User.Identity.Name == null) {
                System.Console.WriteLine("NULL BIATCH");
            } else {
                System.Console.WriteLine(this._contextAccessor.HttpContext.User.Identity.Name);
            }
            System.Console.WriteLine(this._contextAccessor.HttpContext.User?.Identity.Name);
            System.Console.WriteLine("ZZZZZZZZZZZ");



            int connectedUSerId = int.Parse(this._contextAccessor.HttpContext.User.Identity.Name);
            int messageAddedId = await this._chatService.NewMessage(message, connectedUSerId, discussionId);

            Message messageAdded = await this._chatService.GetMessage(messageAddedId);

            // System.Console.WriteLine("AAAAAAAAAAA " + message + " ZZZZZZZZZZZZZZ");

            await Clients.All.SendAsync("messageReceived", messageAdded.ToDTO());

            // await Clients.All.SendAsync("messageReceived", new MessageDTO { Id = 0, Content = message, Author = new UserMinimal { Id = 0, Username = "userTest" }, CreatedAt = DateTime.Now, DiscussionId = 0 });
        }
    }
}