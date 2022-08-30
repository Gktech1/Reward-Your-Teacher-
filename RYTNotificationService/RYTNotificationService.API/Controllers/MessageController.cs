using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RYTNotificationService.API.Data.Repositories.Interfaces;
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
        }

        [Authorize]
        [HttpPost("SendMessage")]
        public async Task<ActionResult<MessageDto>> CreateChatMessage(CreateMessageDto createMessageDto, string username, string token)
        {
            var response = await _messageService.CreateChatAsync
                (createMessageDto, username, token);

            if (response.Success)
                return Ok(response.Data);
            return BadRequest(response);
        }

        [Authorize]
        [HttpGet("GetMessage{id}")]
        public async Task<ActionResult<MessageDto>> GetChatMessage(string id)
        {
            /*if (!ModelState.IsValid)
                return BadRequest();*/
            
            var message =await _messageService.GetMessageById(id);
           if (message.Success)
                return Ok(message.Data);
            return BadRequest(message);
        }
    }
}
