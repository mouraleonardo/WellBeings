using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contact.Models
{
    public class ContactUs
    {
        [Required]
        [StringLength(30, ErrorMessage = "Name cannot be longer than 30 characters.")]
        [Display(Name = "Your Name.")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Subject cannot be longer than 50 characters.")]
        [Display(Name = "Your subject.")]
        public string Subject { get; set; }
        [Required]
        [StringLength(1000, ErrorMessage = "Message cannot be longer than 1000 characters.")]
        [Display(Name = "Your message.")]
        public string Message { get; set; }
    }
}