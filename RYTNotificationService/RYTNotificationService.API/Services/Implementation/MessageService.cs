<<<<<<< HEAD
﻿using RYTNotificationService.API.Data.Repositories.Interfaces;
=======
﻿using AutoMapper;
using RYTNotificationService.API.Data.Repositories.Interfaces;

>>>>>>> updated-Message-Notifications-Controller
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Interfaces;

namespace RYTNotificationService.API.Services.Implementation
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IMapper _mapper;

        public MessageService(IMessageRepository messageRepository, IMapper mapper)
        {
            _messageRepository = messageRepository;
            _mapper = mapper;
        }


        public void DisConnected(Connection connection)
        {
            _messageRepository.RemoveConnection(connection);
        }
        public async Task<Connection> AddConnection(string connectionId)
        {
            return await _messageRepository.GetConnection(connectionId);
        }
        public async Task CreateMessage(Message message)
        {
            _messageRepository.AddMessage(message);
            await _messageRepository.Complete();
        }

        public async Task<Response<Message>> GetMessageById(string id)
        {
            var response = new Response<Message>();
            try
            {
                response.Data = await _messageRepository.GetMessageById(id);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<Response<IEnumerable<MessageDto>>> GetNotificationResult
            (string currentUserName, string recipientUserName)
        {
            var response = new Response<IEnumerable<MessageDto>>();
            response.Data = await _messageRepository.GetMessageThread
                (currentUserName, recipientUserName);
            response.Success = true;
            return response;
        }
        public async Task<Response<MessageDto>> CreateChatAsync
           (CreateMessageDto createMessageDto, string username, string token)
        {
            var userName = ""; // Context.User.GetUserName();
            var response = new Response<MessageDto>();

            if (username == createMessageDto.RecipientUserName.ToLower())
            {
                response.Message = "You cannot send message to yourself";
                return response;
            }


            var message = new Message
            {
                SenderId = "24",
                RecipientId = "56",
                SenderUserName = username,
                RecipientUserName = createMessageDto.RecipientUserName,
                Content = createMessageDto.content
            };

            await CreateMessage(message);
            var messageDto = _mapper.Map<MessageDto>(message);
            response.Data = messageDto;
            response.Success = true;
            return response;
        }
    }
}
