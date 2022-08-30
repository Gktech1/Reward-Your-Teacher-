using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;

namespace RYTNotificationService.API.Services.Interfaces
{
    public interface IMessageService
    {
        void DisConnected(Connection connection);
        Task<Connection> AddConnection(string connectionId);
        Task CreateMessage(Message message);
        Task<Response<Message>> GetMessageById(string id);
        Task<Response<IEnumerable<MessageDto>>> GetNotificationResult
            (string currentUserName, string recipientUserName);
        Task<Response<MessageDto>>CreateChatAsync
           (CreateMessageDto createMessageDto, string username, string token);
    }
}
