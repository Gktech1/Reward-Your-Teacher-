namespace RYTNotificationService.API.Models
{
    public class Connection : BaseEntity
    {
        public Connection()
        {
        }
        public Connection(string connectionId, string username)
        {
            Id = connectionId;
            Username = username;
        }

        public string Username { get; set; }
    }
}
