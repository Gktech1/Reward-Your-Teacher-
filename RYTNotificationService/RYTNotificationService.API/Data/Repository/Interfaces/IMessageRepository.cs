using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Helpers;
using RYTNotificationService.API.Models;

namespace RYTNotificationService.API.Data.Repository.Interfaces
{
    public interface IMessageRepository
    {
        void RemoveConnection(Connection connection);
        Task<Connection> GetConnection(string connectionId);
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessageById(string id);

        Task<PagedList<MessageDto>> GetMessageForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(string currentUserName, string recipientUserName);

        Task<bool> Complete();
    }
}
