
using chat.Models;

namespace chat.Hubs
{
    public interface IHubProvider
    {
        Task ReceivedMessage(Message message);
    }
}