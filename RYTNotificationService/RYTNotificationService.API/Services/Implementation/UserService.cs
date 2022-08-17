using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Interfaces;

namespace RYTNotificationService.API.Services.Implementation
{
    public class UserService : IUserService
    {

        private readonly IHttpClientService _httpClientService;

        public UserService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }
        public async Task<AppUser> GetUserById(string id, string token)
        {
            return await _httpClientService.GetRequestAsync<AppUser>(
                requestUrl: $"/{id}", null, token
            );
        }

        public async Task<AppUser> GetUserByUsername(string username, string token)
        {
            return await _httpClientService.GetRequestAsync<AppUser>(
                requestUrl: $"/{username}", null, token
            );
        }
    }
}
