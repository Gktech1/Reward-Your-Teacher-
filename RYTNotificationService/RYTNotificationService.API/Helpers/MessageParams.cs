namespace RYTNotificationService.API.Helpers
{
    public class MessageParams : PaginationParams
    {
        public string UserName { get; set; }
        public string Container { get; set; } = "Unread";

    }

    public class MessageParamsId : PaginationParams
    {
        public string UserId { get; set; }

    }
}
