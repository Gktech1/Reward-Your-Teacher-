using System.ComponentModel.DataAnnotations;

namespace RYTNotificationService.API.Models
{
    public class Message : BaseEntity
    {
        [Required]
        public string SenderId { get; set; }
        [Required]
        public string SenderUserName { get; set; }
        [Required]
        public string RecipientId { get; set; }
        [Required]
        public string RecipientUserName { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime MessageSent { get; set; } = DateTime.UtcNow;
        public bool IsRead { get; set; }
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; }
    }
}
