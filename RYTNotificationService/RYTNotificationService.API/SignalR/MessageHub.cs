using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Extensions;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Interfaces;

namespace RYTNotificationService.API.SignalR
{

    [Authorize]
    public class MessageHub : Hub
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;
        private readonly IHubContext<PresenceHub> _presenceHub;
        private readonly PresenceTracker _tracker;
        private readonly IUserService _userService;

        public MessageHub(IMessageService messageService, IMapper mapper,
            IUserService userService,
            IHubContext<PresenceHub> presenceHub,
            PresenceTracker tracker)
        {
            _messageService = messageService;
            _mapper = mapper;
            _userService = userService;
            _presenceHub = presenceHub;
            _tracker = tracker;
        }

        public async Task OnConnectedAsync(string username, string token)
        {
            var httpContext = Context.GetHttpContext();
            var client = httpContext.Request.Query["User"].ToString();

            var message = await _userService.GetUserByUsername(username, token);
            await Clients.Caller.SendAsync("ReceivedMessageThread", message);
        }

        public async Task SendMessage(CreateMessageDto createMessageDto)
        {
            if (createMessageDto.SenderUserName == createMessageDto.RecipientUserName.ToLower())
                throw new HubException("You cannot send message to yourself");

            // var sender = await _userService.GetUserByUsername(username, token);
            // var recipient = await _userService.GetUserByUsername(createMessageDto.RecipientUserName, token);

            if (createMessageDto.RecipientUserName == null ||
                createMessageDto.SenderUserName == null ||
                string.IsNullOrEmpty(createMessageDto.SenderId) ||
                string.IsNullOrEmpty(createMessageDto.RecipientId)
                )
                throw new HubException("Incomplete required detail");

            var message = new Message
            {
                SenderUserName = createMessageDto.SenderUserName,
                RecipientUserName = createMessageDto.RecipientUserName,
                SenderId = createMessageDto.SenderId,
                RecipientId = createMessageDto.RecipientId,
                Content = createMessageDto.content
            };

            var connections = await _tracker.GetConnectionForUser(createMessageDto.SenderUserName);
            if (connections != null)
            {
                await _presenceHub.Clients.Clients(connections)
                    .SendAsync("NewMessageReceived", new
                    {
                        username = createMessageDto.SenderUserName,
                        createMessageDto.RecipientUserName
                    });
            }
            _messageService.CreateMessage(message);
        }
    }
}
