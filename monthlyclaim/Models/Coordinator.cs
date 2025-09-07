using System;
using System.ComponentModel.DataAnnotations;

namespace monthlyclaim.Models
{
    public class Coordinator
    {
        [Key]
        public int ClaimId { get; set; } // 3-digit claim ID

        [Required]
        public int LecturerId { get; set; } // Single-digit lecturer ID

        [Required]
        [RegularExpression(@"^[A-Z][0-9]{3}$")]
        public string ModuleId { get; set; } // First letter + 3 digits

        [Required]
        public string LecturerName { get; set; }

        [Required]
        public string CourseName { get; set; }

        [Required]
        public string ModuleName { get; set; }

        [Required]
        public int HoursWorked { get; set; }

        [Required]
        public decimal HourlyRate { get; set; }

        public decimal TotalAmount => HoursWorked * HourlyRate;

        public DateTime SubmissionDate { get; set; }

        public DateTime CloseDate { get; set; }

        public string Status { get; set; } // Pending, Approved, Rejected
    }
}
