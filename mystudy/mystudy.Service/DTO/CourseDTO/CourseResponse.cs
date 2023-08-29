using Data_Layer.Models;
using System.ComponentModel.DataAnnotations;

namespace Service.DTO.CourseDTO
{
    public class CourseResponse
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Length { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public Guid? MentorId { get; set; }
        [Required]
        public string Mentor { get; set; }

        public ICollection<Student>? Students { get; set; }
    }
}