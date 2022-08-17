using System.Net.Http.Headers;
using Newtonsoft.Json;
using RYTNotificationService.API.DTOs;

namespace RYTNotificationService.API.Services.Interfaces
{
    public interface IHttpClientService
    {
        Task<TRes> PostRequestAsync<TReq, TRes>(string requestUrl, TReq requestModel, string baseUrl = null, string token = null)
            where TRes : class
            where TReq : class;
        Task<TRes> GetRequestAsync<TRes>(string requestUrl, string baseUrl = null, string token = null)
            where TRes : class;
    }
}
