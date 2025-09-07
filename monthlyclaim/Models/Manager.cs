using System;
using System.ComponentModel.DataAnnotations;

namespace monthlyclaim.Models
{
    public class Manager
    {
        [Key]
        public int ClaimId { get; set; }

        [Required]
        public string LecturerName { get; set; }

        [Required]
        public DateTime SubmissionDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public string Status { get; set; } // Pending, Approved, Rejected
    }
}

