using Microsoft.EntityFrameworkCore;
using RYTNotificationService.API.Models;

namespace RYTNotificationService.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Connection> Connections { get; set; }

        public DbSet<Notification> Notifications { get; set; }


    }
}
