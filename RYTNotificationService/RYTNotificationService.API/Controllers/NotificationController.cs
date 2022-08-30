using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services;
using RYTNotificationService.API.Services.Interfaces;
using static RYTNotificationService.API.Data.Repositories.Interfaces.INotificationRepository;

namespace RYTNotificationService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //[Authorize]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("SendNotification")]
        public async Task<ActionResult<NotificationDto>> CreateNotification
            (CreateNotificationDto createNotificationDto, string username, string token)
        {
            var response = await _notificationService.PushNotificationAsync
                (createNotificationDto, username, token);

            if (response.Success)
                return Ok(response.Data);
            return BadRequest(response);
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