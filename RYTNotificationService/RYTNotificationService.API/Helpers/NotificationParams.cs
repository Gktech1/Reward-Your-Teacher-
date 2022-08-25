namespace RYTNotificationService.API.Helpers
{
    public class NotificationParams: PaginationParams
    {
        public string UserName { get; set; }
        public string Container { get; set; } = "Unread";
    }
}
