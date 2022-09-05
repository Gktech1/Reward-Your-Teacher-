namespace RYTNotificationService.API.DTOs
{
    public class CreateMessageDto
    {
        public string RecipientUserName { get; set; }
        public  string SenderUserName { get; set; }
        public string SenderId { get; set; }
        public string RecipientId { get; set; }

        public string content { get; set; }
    }
}
