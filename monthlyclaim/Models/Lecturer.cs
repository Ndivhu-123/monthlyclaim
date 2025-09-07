namespace monthlyclaim.Models;

using System.ComponentModel.DataAnnotations;

    // Represents a lecturer's profile and claim details
    public class Lecturer
    {
        [Key]
        public int LecturerId { get; set; } // Unique ID

        [Required]
        public string Name { get; set; } // Lecturer's full name

        [Required]
        public string CourseName { get; set; } // Course being taught

        [Required]
        public string ModuleName { get; set; } // Specific module

        [Required]
        public int HoursWorked { get; set; } // Total hours worked

        [Required]
        public decimal HourlyRate { get; set; } // Rate per hour

        public decimal TotalAmount => HoursWorked * HourlyRate; // Auto-calculated

        public string Status { get; set; } // Claim status (Pending, Approved, etc.)
    }
