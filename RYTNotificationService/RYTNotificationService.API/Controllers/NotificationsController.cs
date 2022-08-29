using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Services.Interfaces;

namespace RYTNotificationService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationServices;
        private readonly IUserService _userservice;
        private readonly IMapper _mapper;


        public NotificationsController(INotificationService notificationServices, 
            IMapper mapper, 
            IUserService userservice)
        {
            _notificationServices = notificationServices;
            _mapper = mapper;
            _userservice = userservice;

        }
        [HttpPatch("{NotificationId}/{RecipientId}")]
        public async Task<IActionResult> MarkNotificationRead(string NotificationId, string RecipientId)
        {

            var data = await _notificationServices.MarkInAppNotifications(NotificationId, RecipientId);
            if (data.Success)
                return Ok(data);

            return BadRequest(data);

        }
  


        [HttpPost("SendNotification")]
        public async Task<ActionResult<NotificationDto>> CreateNotification(CreateNotificationDto createNotificationDto, string username, string token)
        {
            var userName = ""; // Context.User.GetUserName();

            if (username == createNotificationDto.RecipientUserName.ToLower())
                return BadRequest("You cannot send message to yourself");


            var notification = new Notification
            {
                SenderId = "24",
                RecipientId = "56",
                SenderUserName = username,
                RecipientUserName = createNotificationDto.RecipientUserName,
                Content = createNotificationDto.content
            };

            _notificationServices.CreateNotification(notification);

            if (await _notificationServices.Saved()) return Ok(notification);  //Ok(_mapper.Map<NotificationDto>(notification));

            return BadRequest("Failed to send notification");
        }


    }







}
