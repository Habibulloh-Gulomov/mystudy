namespace Data_Layer.Models
{
    public class Course
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Length { get; set; }

        public int Price { get; set; }

        public Guid? MentorId { get; set; }

        public Mentor? Mentor { get; set; }

        public ICollection<Student>? Students { get; set; }
    }
}