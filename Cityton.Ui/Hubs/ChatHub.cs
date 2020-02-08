using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Cityton.Data.DTOs;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task NewMessage(string message)
        {
            System.Console.WriteLine("AAAAAAAAAAA " + message + " ZZZZZZZZZZZZZZ");
            await Clients.All.SendAsync("messageReceived", message);
        }
    }
}