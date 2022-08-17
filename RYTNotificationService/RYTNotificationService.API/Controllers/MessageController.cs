using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RYTNotificationService.API.Data.Repository.Interfaces;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Interfaces;

namespace RYTNotificationService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public MessageController(IMessageRepository messageRepository, IMapper mapper,
            IMessageService messageService,
            IUserService userService)
        {
            _messageService = messageService;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpPost("SendMessage")]
        public async Task<ActionResult<MessageDto>> CreateChatMessage(CreateMessageDto createMessageDto, string username, string token)
        {
            var userName = "";//User.GetUserName(); // to get current user accessing the chat message

            if (username == createMessageDto.RecipientUserName.ToLower())
                return BadRequest("You can not sent message to yourself");

           // var sender = await _userService.GetUserByUsername(username, token);
            //var recipient = await _userService.GetUserByUsername(createMessageDto.RecipientUserName, token);

            //if (recipient == null) return NotFound();

            var message = new Message()
            {
                SenderId = "23",
                RecipientId = "5",
                SenderUserName = username,
                RecipientUserName = createMessageDto.RecipientUserName,
                Content = createMessageDto.content
            };

            _messageService.CreateMessage(message);
            if (await _messageService.Saved()) return Ok(message); 
            return BadRequest("Failed to send message");
        }
    }
}
