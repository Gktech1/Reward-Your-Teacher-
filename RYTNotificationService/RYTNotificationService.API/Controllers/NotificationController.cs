using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Services.Interfaces;
using RYTNotificationService.API.Helpers;

namespace RYTNotificationService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationServices;
        private readonly IUserService _userservice;
        private readonly IMapper _mapper;


        public NotificationController(INotificationService notificationServices,
            IMapper mapper,
            IUserService userservice)
        {
            _notificationServices = notificationServices;
            _mapper = mapper;
            _userservice = userservice;

        }


        [HttpGet]
        public async Task<IActionResult> GetNotificationByUserId([FromQuery] MessageParamsId param)
        {
            var result = await _notificationServices.GetNotificationByUserIdAsync(param);

            if (result.Success)
                return Ok(result);
            return BadRequest(result);
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
        public async Task<ActionResult<NotificationDto>> CreateNotification
            (CreateNotificationDto createNotificationDto, string username, string token)
        {
            var response = await _notificationServices.PushNotificationAsync
                (createNotificationDto, username, token);

            if (response.Success)
                return Ok(response.Data);
            return BadRequest(response);
        }


    }

}
