using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RYTNotificationService.API.Data;
using RYTNotificationService.API.Data.Repositories.Interfaces;
using RYTNotificationService.API.DTOs;
using RYTNotificationService.API.Helpers;
using RYTNotificationService.API.Models;

namespace RYTNotificationService.API.Repositories.Implementation
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public NotificationRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
<<<<<<< HEAD

        public async Task<PagedList<NotificationDto>> GetNotificationByUserId(MessageParamsId messageParams)
        {
            var query = _context.Notifications
                .OrderByDescending(m => m.NoticeSent)
                .ProjectTo<NotificationDto>(_mapper.ConfigurationProvider)
                .AsQueryable();

            query = query.Where(u => u.RecipientId == messageParams.UserId && u.RecipientDeleted == false);

            return await PagedList<NotificationDto>.CreateAsync(query, messageParams.PageNumber, messageParams.PageSize);
        }

=======
>>>>>>> updated-Message-Notifications-Controller
        public void RemoveConnection(Connection connection)
        {
            _context.Connections.Remove(connection);
        }

        public async Task<Connection> GetConnection(string connectionId)
        {
            return await _context.Connections.FindAsync(connectionId);
        }

<<<<<<< HEAD
        public async Task<Response<bool>> MarkReadNotifications(string NotificationId, string RecieverId)
        {
            if (string.IsNullOrWhiteSpace(NotificationId) || string.IsNullOrWhiteSpace(RecieverId))
                return new Response<bool> { Data = false, Success = false, Message = "This notification id is invalid" };

            var Marked = await _context.Notifications.FirstOrDefaultAsync(x => x.Id == NotificationId && x.RecipientId == RecieverId);
            if (Marked == null)
                return new Response<bool> { Success = false, Message = "Notification cannot be found", Data = false };

            if (Marked.IsRead == true)
                return new Response<bool> { Success = true, Message = "Message is Read", Data = true };

            new Notification
            {
                Id = NotificationId,
                RecipientId = RecieverId,
                IsRead = true,
                DateRead = DateTime.Now,
            };
            return new Response<bool> { Data = true, Message = "Message is now Read", Success = true };
        }
=======
>>>>>>> updated-Message-Notifications-Controller
        public void AddNotification(Notification notification)
        {
            _context.Add(notification);
        }

        public void DeleteNotification(Notification notification)
        {
            _context.Notifications.Remove(notification);
        }

        public async Task<Notification> GetNotificationById(string id)
        {
            return await _context.Notifications
                .Include(u => u.SenderId)
                .Include(u => u.RecipientId)
<<<<<<< HEAD
                .SingleOrDefaultAsync(u => u.Id == id);
=======
                .SingleOrDefaultAsync(x => x.Id == id);
>>>>>>> updated-Message-Notifications-Controller
        }

        public async Task<PagedList<NotificationDto>> GetNotificationForUser(NotificationParams notificationParams)
        {
            var query = _context.Notifications
                .OrderByDescending(m => m.NoticeSent)
                .ProjectTo<NotificationDto>(_mapper.ConfigurationProvider)
                .AsQueryable();

            query = notificationParams.Container switch
            {
                "Inbox" => query.Where(
                    u => u.RecipientUserName == notificationParams.UserName && u.RecipientDeleted == false),
                "Outbox" => query.Where(u => u.SenderUserName == notificationParams.UserName && u.SenderDeleted == false),
                _ => query.Where(u =>
                    u.RecipientUserName == notificationParams.UserName && u.RecipientDeleted == false && u.DateRead == null)
            };

            //Task<PagedList<T>> CreateAsync(IQueryable<T> source, int pageNumber, int pageSize)
            return await PagedList<NotificationDto>.CreateAsync(query, notificationParams.PageNumber, notificationParams.PageSize);

            //messageParams.UserName && u.SenderDeleted == false);
        }


        public async Task<IEnumerable<NotificationDto>> GetNotificationThread(string currentUserName, string recipientUserName)
        {
            var notifications = await _context.Notifications
                .Where(m => m.RecipientUserName == currentUserName
                            && m.RecipientDeleted == false
                            && m.SenderUserName == recipientUserName
                            || m.RecipientUserName == recipientUserName
                            && m.SenderUserName == currentUserName && m.SenderDeleted == false)
                .OrderBy(m => m.NoticeSent)
                .ProjectTo<NotificationDto>(_mapper.ConfigurationProvider)
                .ToListAsync();

            var usereadNotifications = notifications.Where(m => m.DateRead == null && m.RecipientUserName == currentUserName)
                .ToList();

            if (usereadNotifications.Any())
            {
                foreach (var notification in usereadNotifications)
                {
                    notification.DateRead = DateTime.UtcNow;
                }
            }

            return notifications;
        }

        public async Task<bool> Complete()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
