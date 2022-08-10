using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmailSenders.Entity
{
    public class MailRequest
    {
       
            [Required]
            [EmailAddress]  
            public string RecepientEmail { get; set; }
            [Required]
            [StringLength(100, ErrorMessage = "Title is too large" )]
            public string Subject { get; set; }
            public string Body { get; set; }
            public List<IFormFile> Attachments { get; set; }
        }
    
}
