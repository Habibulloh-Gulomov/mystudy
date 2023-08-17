using System.ComponentModel.DataAnnotations;
namespace Data_Layer.Models
{
    public class Mentor
    {
        [Key]
        public int Id { get; set; }
        
        public int Age { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Course Course { get; set; }

        public ICollection<Student> students { get; set; } = new List<Student>();

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
