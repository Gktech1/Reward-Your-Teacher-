﻿using EmailSenders.Entity;
using EmailSenders.Services;
using EmailSenders.Settings;
using MailKit.Net.Smtp;
using MailKit.Security;

using Microsoft.Extensions.Options;
using MimeKit;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Models;
using System.IO;
using System.Threading.Tasks;

namespace RYTNotificationService.API.Services.Implementation
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public async Task<Response<bool>> SendEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.RecepientEmail));
            email.Subject = mailRequest.Subject;
            var builder = new BodyBuilder();
            if (mailRequest.Attachments != null)
            {
                byte[] fileBytes;
                foreach (var file in mailRequest.Attachments)
                {
                    if (file.Length > 0)
                    {
                        using (var ms = new MemoryStream())
                        {
                            file.CopyTo(ms);
                            fileBytes = ms.ToArray();
                        }
                        builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
                    }
                }
            }
            builder.HtmlBody = mailRequest.Body;
            email.Body = builder.ToMessageBody();

            try
            {
                using var smtp = new SmtpClient();
                smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
                return new Response<bool> { Data = true, Message = "Email was sent successfully", Success = true };
            }
            catch (Exception ex)
            {
                return new Response<bool> { Data = false, Message = "Email was not sent", Success = false };
            }
        }
    }
}
