using System;
using System.ComponentModel.DataAnnotations;

namespace SmartWorkforcePortal.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }

        [Required]
        public string UserId { get; set; } // Link to Identity user

        [Required]
        [Display(Name = "Request Type")]
        public string RequestType { get; set; } // Leave, Access, Training, Equipment

        [Required]
        public string Description { get; set; }

        [Required]
        public string Status { get; set; } // Pending, Approved, Rejected

        [Required]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
    }
}
