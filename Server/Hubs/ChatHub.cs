using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorWebAssemblySignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            if(string.IsNullOrEmpty(user))
            {
                user = "Anonymous";
            }

           
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
