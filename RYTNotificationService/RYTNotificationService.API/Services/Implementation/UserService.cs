using RYTNotificationService.API.Models;
using RYTNotificationService.API.Services.Interfaces;

namespace RYTNotificationService.API.Services.Implementation
{
    public class UserService : IUserService
    {

        private readonly IHttpClientService _httpClientService;
        private readonly IConfiguration _config;

        public UserService(IHttpClientService httpClientService, IConfiguration config)
        {
            _httpClientService = httpClientService;
            _config = config;
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
                requestUrl: "User/api/v1/LoginUser", _config["BaseUrl"], _config["token"]
            );
        }
    }
}
