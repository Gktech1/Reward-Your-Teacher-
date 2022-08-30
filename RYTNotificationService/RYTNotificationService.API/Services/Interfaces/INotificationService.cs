using RYTNotificationService.API.DTOs;
<<<<<<< HEAD
using RYTNotificationService.API.Helpers;
=======
>>>>>>> updated-Message-Notifications-Controller
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Implementation;

namespace RYTNotificationService.API.Services.Interfaces
{
    public interface INotificationService
    {
        void DisConnected(Connection connection);
<<<<<<< HEAD
        Task<Response<bool>> MarkInAppNotifications(string NotificationId, string RecieverId);
        Task<Connection> AddConnection(string connectionId);
        void CreateNotification(Notification notification);
        Task<Notification> GetNotificationById(string id);
        Task<IEnumerable<NotificationDto>> GetNotificationResult(string currentUserName, string recipientUserName);

        Task<Response<PagedList<NotificationDto>>> GetNotificationByUserIdAsync(MessageParamsId messageParams);

        Task<bool> Saved();
=======
        Task<Connection> AddConnection(string connectionId);
        Task CreateNotification(Notification notification);
        Task<Response<NotificationDto>> PushNotificationAsync
            (CreateNotificationDto createNotificationDto, string username, string token);
        Task<Response<Notification>> GetNotificationById(string id);
        Task<Response<IEnumerable<NotificationDto>>> GetNotificationResult
            (string currentUserName, string recipientUserName);
>>>>>>> updated-Message-Notifications-Controller
    }
}
