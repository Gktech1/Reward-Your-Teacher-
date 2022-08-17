using RYTNotificationService.API.Data.Repository.Interfaces;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Interfaces;

namespace RYTNotificationService.API.Services.Implementation
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public void DisConnected(Connection connection)
        {
            _messageRepository.RemoveConnection(connection);
        }
        public async Task<Connection> AddConnection(string connectionId)
        {
            return await _messageRepository.GetConnection(connectionId);
        }
        public void CreateMessage(Message message)
        {
            _messageRepository.AddMessage(message);
        }

        public async Task<Message> GetMessageById(string id)
        {
            return await _messageRepository.GetMessageById(id);
        }

        public async Task<IEnumerable<MessageDto>> GetMessageResult(string currentUserName, string recipientUserName)
        {
            return await _messageRepository.GetMessageThread(currentUserName, recipientUserName);
        }

        public async Task<bool> Saved()
        {
            return await _messageRepository.Complete();
        }
    }
}
