using Microsoft.AspNetCore.SignalR;
using RYTNotificationService.API.Data.Repositories.Interfaces;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Interfaces;
using RYTNotificationService.API.SignalR;
using System.Text.Json;
using System.Threading.Channels;

namespace RYTNotificationService.API.Services.Implementation
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;

        public NotificationService(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }


        public void DisConnected(Connection connection)
        {
            _notificationRepository.RemoveConnection(connection);
        }
        public async Task<Connection> AddConnection(string connectionId)
        {
            return await _notificationRepository.GetConnection(connectionId);
        }
        public void CreateNotification(Notification notification)
        {
            _notificationRepository.AddNotification(notification);
        }

        public async Task<Notification> GetNotificationById(string id)
        {
            return await _notificationRepository.GetNotificationById(id);
        }

        public async Task<IEnumerable<NotificationDto>> GetNotificationResult(string currentUserName, string recipientUserName)
        {
            return await _notificationRepository.GetNotificationThread(currentUserName, recipientUserName);
        }

        public async Task<bool> Saved()
        {
            return await _notificationRepository.Complete();
        } 
    }
}
