using EmailSenders.Entity;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using System.Threading.Tasks;

namespace EmailSenders.Services
{
    public interface IMailService
    {
        Task<Response<bool>> SendEmailAsync(MailRequest mailRequest);
    }
}
