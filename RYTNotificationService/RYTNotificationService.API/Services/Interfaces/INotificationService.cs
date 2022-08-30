using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Helpers;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Implementation;

namespace RYTNotificationService.API.Services.Interfaces
{
    public interface INotificationService
    {
        void DisConnected(Connection connection);

        Task<Response<bool>> MarkInAppNotifications(string NotificationId, string RecieverId);
        Task<Connection> AddConnection(string connectionId);
        Task CreateNotification(Notification notification);
        Task<Notification> GetNotificationById(string id);
        Task<Response<IEnumerable<NotificationDto>>> GetNotificationResult(string currentUserName, string recipientUserName);

        Task<Response<PagedList<NotificationDto>>> GetNotificationByUserIdAsync(MessageParamsId messageParams);

        Task<Response<NotificationDto>> PushNotificationAsync
          (CreateNotificationDto createNotificationDto, string username, string token);

        Task<bool> Saved();

    }
}
