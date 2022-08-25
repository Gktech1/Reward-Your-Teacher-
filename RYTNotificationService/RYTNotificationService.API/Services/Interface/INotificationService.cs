using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Implementation;

namespace RYTNotificationService.API.Services.Interface
{
    public interface INotificationService
    {
        void DisConnected(Connection connection);
        Task<Connection> AddConnection(string connectionId);
        void CreateNotification(Notification notification);
        Task<Notification> GetNotificationById(string id);
        Task<IEnumerable<NotificationDto>> GetNotificationResult(string currentUserName, string recipientUserName);

        Task<bool> Saved();
    }
}
