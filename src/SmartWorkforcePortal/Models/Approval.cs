using System;
using System.ComponentModel.DataAnnotations;

namespace SmartWorkforcePortal.Models
{
    public class Approval
    {
        [Key]
        public int ApprovalId { get; set; }

        [Required]
        public int RequestId { get; set; } // FK to Request

        [Required]
        public string ApproverId { get; set; } // IdentityUser Id of Supervisor

        [Required]
        public string Decision { get; set; } // Approved or Rejected

        public string Comments { get; set; }

        [Required]
        public DateTime DecisionDate { get; set; }
    }
}
