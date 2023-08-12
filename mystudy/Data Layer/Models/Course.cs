namespace Data_Layer.Models
{
    public class Course
    {
        public Guid CourseId { get; set; }

        public string CourseName { get; set; }

        public string CourseLength { get; set; }

        public int CoursePrice { get; set; }

        public string MentorName { get; set; }

        public Mentor Mentor { get; set; }

        public string StudentName { get; set; }

        public Student Student { get; set; }
    }
}
