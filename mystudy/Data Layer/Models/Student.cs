using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool isPaid { get; set; }

        public Guid CourseId { get; set; } 

        public Course Courses { get; set; }
    }
}