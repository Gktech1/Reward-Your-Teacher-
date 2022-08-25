using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Interfaces;

namespace RYTNotificationService.API.SignalR
{
    public class NotificationHub : Hub
    {
        private readonly INotificationService _notification;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IHubContext<PresenceHub> _presenceHub;
        private readonly PresenceTracker _tracker;

        public NotificationHub(INotificationService notification, 
            IMapper mapper,
            IHubContext<PresenceHub> presenceHub,
            PresenceTracker _tracker,
        IUserService userService)
        {
            _notification = notification;
            _mapper = mapper;
            _userService = userService;
        }

        public async Task OnConnectedAsync(string username, string token)
        {
            var httpContext = Context.GetHttpContext();
            var client = httpContext.Request.Query["User"].ToString();

            var notification = await _userService.GetUserByUsername(username, token);
            await Clients.Caller.SendAsync("ReceivedNotificationThread", notification);
        }

        public async Task PushNotification(CreateNotificationDto createNotificationDto, string username, string token)
        {
            var userName = "";//Context.User.GetUserName();

            if (userName == createNotificationDto.RecipientUserName.ToLower())
                throw new HubException("You cannot send notification to yourself");

            var sender = await _userService.GetUserByUsername(username, token);
            var recipient = await _userService.GetUserByUsername(createNotificationDto.RecipientUserName, token);

            if (recipient == null) throw new HubException("User not found");
            var notification = new Notification

            {
                SenderUserName = sender.UserName,
                RecipientUserName = recipient.UserName,
                SenderId = sender.Id,
                RecipientId = recipient.Id,
                Content = createNotificationDto.content
            };

            var connections = await _tracker.GetConnectionForUser(recipient.UserName);
            if (connections != null)
            {
                await _presenceHub.Clients.Clients(connections)
                    .SendAsync("NewNotificationReceived", new
                    {
                        username = sender.UserName,
                        sender.UserName
                    });  
            }

            _notification.CreateNotification(notification);
        }
    }
}
