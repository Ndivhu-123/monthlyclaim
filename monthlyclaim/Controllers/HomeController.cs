using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using monthlyclaim.Models;

namespace monthlyclaim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        // Show Sign-Up page
        public IActionResult SignUp()
        {
            return View();
        }

        // Handle Sign-Up and redirect to Login page with welcome message
        [HttpPost]
        public IActionResult signup(string username, string password, string email, string role)
        {
            

            TempData["WelcomeMessage"] = "YOU ARE NOW A MEMBER!";
            return RedirectToAction("Login");
        }
        // Show Login page
        public IActionResult Login()
        {
            return View();
        }
        // Handle Login and redirect based on role
        
        [HttpPost]
        public IActionResult LogIn(string username, string password, string role)
        {

            if (role == "Lecturer")
            {
                var lecturer = new Lecturer
                {
                    Name = username,
                    CourseName = "Computer Science",
                    ModuleName = "Web Development",
                    HoursWorked = 10,
                    HourlyRate = 200,
                    Status = "Pending"
                };

                return View("Lecturer", lecturer); // Opens Lecturer.cshtml with model
            }

            if (role == "Coordinator")
                return RedirectToAction("Coordinator");

            if (role == "Manager")
                return RedirectToAction("Manager");

            return RedirectToAction("Login"); // fallback
        }

        public IActionResult Lecturer(string username)
        {
            var lecturer = new Lecturer
            {
                LecturerId = 1,
                Name = username,
                CourseName = "Computer Science",
                ModuleName = "Web Development",
                HoursWorked = 10,
                HourlyRate = 200,
                Status = "Pending"
            };

            return View(lecturer);
        }

        // Show Submit Claim page
        public IActionResult SubmitClaim()
{
    return View();
}

// Show Track Claim page
public IActionResult TrackClaim()
{
    return View();
}


        
        public IActionResult Manager(string username)
        {
            ViewBag.ManagerName = username;

            var finalClaims = new List<Manager>
    {
        new Manager
        {
            ClaimId = 1,
            LecturerName = "Thabo Zungu",
            SubmissionDate = new DateTime(2025, 9, 1),
            TotalAmount = 2400,
            Status = "Pending"
        },
        new Manager
        {
            ClaimId = 2,
            LecturerName = "Nana Khumalo",
            SubmissionDate = new DateTime(2025, 9, 2),
            TotalAmount = 1800,
            Status = "Approved"
        },
        new Manager
        {
            ClaimId = 3,
            LecturerName = "Ndivhuwo Ndou",
            SubmissionDate = new DateTime(2025, 9, 3),
            TotalAmount = 1760,
            Status = "Pending"
        },
        new Manager
        {
            ClaimId = 4,
            LecturerName = "Xihluke Baloyi",
            SubmissionDate = new DateTime(2025, 9, 4),
            TotalAmount = 2660,
            Status = "Pending"
        }
    };

            return View(finalClaims);
        }



        public IActionResult Coordinator(string username)
        {
            ViewBag.CoordinatorName = username;

            var pendingClaims = new List<Coordinator>
    {
        new Coordinator
        {
            ClaimId = 001,
            LecturerId = 1,
            ModuleId = "P483",
            LecturerName = "Thabo Zungu",
            CourseName = "Software Development",
            ModuleName = "Programming",
            HoursWorked = 12,
            HourlyRate = 200,
            SubmissionDate = new DateTime(2025, 9, 1),
            CloseDate = new DateTime(2025, 9, 5),
            Status = "Pending"
        },
        new Coordinator
        {
            ClaimId = 003,
            LecturerId = 3,
            ModuleId = "W927",
            LecturerName = "Ndivhuwo Ndou",
            CourseName = "Computer Science",
            ModuleName = "Web Development",
            HoursWorked = 8,
            HourlyRate = 220,
            SubmissionDate = new DateTime(2025, 9, 3),
            CloseDate = new DateTime(2025, 9, 7),
            Status = "Pending"
        },
        new Coordinator
        {
            ClaimId = 004,
            LecturerId = 4,
            ModuleId = "N614",
            LecturerName = "Xihluke Baloyi",
            CourseName = "Information Technology",
            ModuleName = "Networking",
            HoursWorked = 14,
            HourlyRate = 190,
            SubmissionDate = new DateTime(2025, 9, 4),
            CloseDate = new DateTime(2025, 9, 8),
            Status = "Pending"
        }
    };

            var approvedClaims = new List<Coordinator>
    {
        new Coordinator
        {
            ClaimId = 002,
            LecturerId = 2,
            ModuleId = "S105",
            LecturerName = "Nana Khumalo",
            CourseName = "Business Information Systems",
            ModuleName = "System Analysis and Design",
            HoursWorked = 10,
            HourlyRate = 180,
            SubmissionDate = new DateTime(2025, 9, 2),
            CloseDate = new DateTime(2025, 9, 6),
            Status = "Approved"
        }
    };

            var allClaims = pendingClaims.Concat(approvedClaims).ToList();
            return View(allClaims);
        }

        public IActionResult MoreInfo()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
