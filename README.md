# monthlyclaim
Overview
CMCS is a web-based application designed to streamline the submission, tracking, and approval of academic claims for Independent Contractor lecturers. The system features role-based dashboards tailored for lecturers, programme coordinators, and academic managers. It supports multiple modules and courses, and is built with a focus on clarity, accessibility, and professional presentation.

Features
Lecturer Dashboard
Submit monthly claims with supporting documentation

View claim summaries with auto-calculated totals

Personalized greeting and clean layout

Programme Coordinator Dashboard
Review pending claims with full metadata

Approve or reject claims with one-click actions

View Lecturer ID, Claim ID, and Module ID for each submission

Academic Manager Dashboard
Monitor approved and rejected claims

Track submission and close dates

Ensure policy compliance and institutional integrity

Technologies Used
ASP.NET Core MVC

C#

Razor Views

HTML and CSS (custom styling with soft beige and dust pink tones)

Entity Framework (for future database integration)

Data Structure
Each claim record includes the following fields:

LecturerId: Single-digit integer (e.g., 1)

ClaimId: Three-digit integer formatted as a string (e.g., 001, 002)

ModuleId: A string composed of the first letter of the module name followed by three random digits (e.g., P483 for Programming)

LecturerName, CourseName, ModuleName

HoursWorked, HourlyRate, TotalAmount (auto-calculated)

SubmissionDate, CloseDate, Status
