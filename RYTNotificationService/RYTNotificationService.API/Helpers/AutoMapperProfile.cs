using AutoMapper;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;

namespace RYTNotificationService.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Message, MessageDto>().ReverseMap();
        }
    }
}
