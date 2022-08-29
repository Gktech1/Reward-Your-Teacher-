using Microsoft.EntityFrameworkCore;
using RYTNotificationService.API.Data;
using Microsoft.AspNetCore.SignalR;
using RYTNotificationService.API.Data.Repositories.Interfaces;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Interfaces;
using RYTNotificationService.API.SignalR;
using System.Text.Json;
using System.Threading.Channels;
using AutoMapper;
using RYTNotificationService.API.Helpers;

namespace RYTNotificationService.API.Services.Implementation
{
    public class NotificationService : INotificationService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly INotificationRepository _notificationRepository;

        public NotificationService(INotificationRepository notificationRepository,
            DataContext context, IMapper mapper)
        {
            _context = context;
            _notificationRepository = notificationRepository;
            _mapper = mapper;
        }
        public async Task<Response<bool>> MarkInAppNotifications(string NotificationId, string RecieverId)
        {
           return await _notificationRepository.MarkReadNotifications(NotificationId, RecieverId);  
        }

        public async Task<Response<PagedList<NotificationDto>>> GetNotificationByUserIdAsync(MessageParamsId messageParams)
        {
            if (messageParams.UserId == null)
                return new Response<PagedList<NotificationDto>> { Data = null, Message = "UserId cannot be empty", Success = false };

            var notifications = await _notificationRepository.GetNotificationByUserId(messageParams);
            return new Response<PagedList<NotificationDto>> { Data = notifications, Message = "Notification found", Success = true };
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

    }
}