using System.ComponentModel.DataAnnotations;

namespace StudentCourseRegistration.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Student Name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email Address is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Course is required.")]
        [StringLength(50, ErrorMessage = "Course name cannot exceed 50 characters.")]
        public string Course { get; set; } = string.Empty;

        [Required(ErrorMessage = "Semester is required.")]
        [Range(1, 8, ErrorMessage = "Semester must be between 1 and 8.")]
        public int Semester { get; set; }
    }
}