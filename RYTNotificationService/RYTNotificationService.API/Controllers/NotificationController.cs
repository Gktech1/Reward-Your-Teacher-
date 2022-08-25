using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Interfaces;
using static RYTNotificationService.API.Data.Repositories.Interfaces.INotificationRepository;

namespace RYTNotificationService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //[Authorize]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationservice;
        private readonly IUserService _userservice;
        private readonly IMapper _mapper;

        public NotificationController(INotificationService notificationservice,
            IMapper mapper,
           IUserService userservice)
        {
            _notificationservice = notificationservice;
            _mapper = mapper;
            _userservice = userservice;
        }

        [HttpPost("SendNotification")]
        public async Task<ActionResult<NotificationDto>> CreateNotification(CreateNotificationDto createNotificationDto,string username, string token)
        {
            var userName = ""; // Context.User.GetUserName();

            if (username == createNotificationDto.RecipientUserName.ToLower())
                return BadRequest("You cannot send message to yourself");

            //var sender = await _userservice.GetUserByUsername(username, token);
            //var recipient = await _userservice.GetUserByUsername(createNotificationDto.RecipientUserName, token);

            // if (recipient == null) return NotFound();

            /*var notification = new Notification
            {
                SenderId = sender.Id,
                RecipientId = recipient.Id,
                SenderUserName = sender.UserName,
                RecipientUserName = recipient.UserName,
                Content = createNotificationDto.content
            };*/

            var notification = new Notification
            {
                SenderId = "24",
                RecipientId = "56",
                SenderUserName = username,
                RecipientUserName = createNotificationDto.RecipientUserName,
                Content = createNotificationDto.content
            };

            _notificationservice.CreateNotification(notification);

            if (await _notificationservice.Saved()) return Ok(notification);  //Ok(_mapper.Map<NotificationDto>(notification));

            return BadRequest("Failed to send notification");
        }

    }
}












/*
    “Id”: string,
		“SenderId”: string,
		“SenderUsername”: string,
		“RecipientId”: string,
		“RecipientUserName”: string,
		“Content”: string,
		“DateRead”: DateTime
		“DateSent”:  DateTime
		“isRead”: bool
*/