using RYTNotificationService.API.Models;

namespace RYTNotificationService.API.Services.Interface
{
    public interface IUserService
    {
        Task<AppUser> GetUserById(string id, string token);
        Task<AppUser> GetUserByUsername(string username, string token);
    }
}
