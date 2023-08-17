using System.ComponentModel.DataAnnotations;
namespace Data_Layer.Models
{
    public class Mentor
    {
        [Key]
        public Guid Id { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
