using RYTNotificationService.API.Models;

namespace RYTNotificationService.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<AppUser> GetUserById(string id, string token);
        Task<AppUser> GetUserByUsername(string username, string token);
    }
}
