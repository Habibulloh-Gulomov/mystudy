

using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public int StudentAge { get; set; }
        public string StudentGender { get;set;}
        [Required]
        [MinLength(9)]
        [MaxLength(9)]
        public int StudentPhone { get; set; }
        public string StudentEmail { get; set; }
        public int StudentWallet { get; set; }
    }
}
