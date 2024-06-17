using chat.Models;
using Microsoft.AspNetCore.SignalR;

namespace chat.Hubs
{
    public class HubProvider : Hub<IHubProvider>
    {
        public async Task SendMessage(Message message)
        {
            await Clients.All.ReceivedMessage(message);
        }
    }
}