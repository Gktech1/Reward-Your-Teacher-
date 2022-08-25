using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Helpers;
using RYTNotificationService.API.Models;

namespace RYTNotificationService.API.Data.Repositories.Interface
{
    public interface INotificationRepository
    {
        void RemoveConnection(Connection connection);
        Task<Connection> GetConnection(string connectionId);
        void AddNotification(Notification notification);
        void DeleteNotification(Notification notification);
        Task<Notification> GetNotificationById(string id);
        Task<PagedList<NotificationDto>> GetNotificationForUser(NotificationParams notificationParams);
        Task<IEnumerable<NotificationDto>> GetNotificationThread(string currentUserName, string recipientUserName);
        Task<bool> Complete();
    }
}
