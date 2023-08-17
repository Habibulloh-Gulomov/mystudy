

using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Models
{
    public class Student
    {
        public Guid StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int StudentAge { get; set; }
        public string StudentGender { get; set;}
        [Required]
        [MinLength(9)]
        [MaxLength(9)]
        public int StudentPhone { get; set; }
        public string StudentEmail { get; set; }
        public bool isPaid { get; set; }
    }
}
