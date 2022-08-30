<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
using RYTNotificationService.API.Data;
=======
﻿using AutoMapper;
>>>>>>> updated-Message-Notifications-Controller
using Microsoft.AspNetCore.SignalR;
using RYTNotificationService.API.Data.Repositories.Interfaces;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Interfaces;
using RYTNotificationService.API.SignalR;
using System.Text.Json;
using System.Threading.Channels;
<<<<<<< HEAD
using AutoMapper;
using RYTNotificationService.API.Helpers;
=======
>>>>>>> updated-Message-Notifications-Controller

namespace RYTNotificationService.API.Services.Implementation
{
    public class NotificationService : INotificationService
    {
<<<<<<< HEAD
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

=======
        private readonly INotificationRepository _notificationRepository;
        private readonly IMapper _mapper;

        public NotificationService(INotificationRepository notificationRepository, IMapper mapper)
        {
            _notificationRepository = notificationRepository;
            _mapper = mapper;
        }


        public void DisConnected(Connection connection)
        {
            _notificationRepository.RemoveConnection(connection);
>>>>>>> updated-Message-Notifications-Controller
        }
        public async Task<Connection> AddConnection(string connectionId)
        {
            return await _notificationRepository.GetConnection(connectionId);
<<<<<<< HEAD

        }
        public void CreateNotification(Notification notification)
        {
            _notificationRepository.AddNotification(notification);
        }

    }
}
=======
        }
        public async Task CreateNotification(Notification notification)
        {
            _notificationRepository.AddNotification(notification);
            await _notificationRepository.Complete();
        }

        public async Task<Response<Notification>> GetNotificationById(string id)
        {
            var response = new Response<Notification>();
            try
            {
                response.Data = await _notificationRepository.GetNotificationById(id);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<IEnumerable<NotificationDto>>> GetNotificationResult
            (string currentUserName, string recipientUserName)
        {
            var response = new Response<IEnumerable<NotificationDto>>();
            response.Data = await _notificationRepository.GetNotificationThread
                (currentUserName, recipientUserName);
            response.Success = true;
            return response;
        }

        public async Task<Response<NotificationDto>> PushNotificationAsync
            (CreateNotificationDto createNotificationDto, string username, string token)
        {
            var userName = ""; // Context.User.GetUserName();
            var response = new Response<NotificationDto>();

            if (username == createNotificationDto.RecipientUserName.ToLower())
            {
                response.Message = "You cannot send message to yourself";
                return response;
            }


            var notification = new Notification
            {
                SenderId = "24",
                RecipientId = "56",
                SenderUserName = username,
                RecipientUserName = createNotificationDto.RecipientUserName,
                Content = createNotificationDto.content
            };

            await CreateNotification(notification);
            var notificationDto = _mapper.Map<NotificationDto>(notification);
            response.Data = notificationDto;
            response.Success = true;
            return response;
        }


    }
}
>>>>>>> updated-Message-Notifications-Controller
