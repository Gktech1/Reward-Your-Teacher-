using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;

namespace RYTNotificationService.API.Services.Interfaces
{
    public interface IMessageService
    {
        void DisConnected(Connection connection);
        Task<Connection> AddConnection(string connectionId);
        void CreateMessage(Message message);
        Task<Message> GetMessageById(string id);
        Task<IEnumerable<MessageDto>> GetMessageResult(string currentUserName, string recipientUserName);

        Task<bool> Saved();
    }
}
