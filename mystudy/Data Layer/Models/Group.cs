


namespace Data_Layer.Models
{
    public class Group
    {
        public Guid GroupId { get; set; }
        public string GroupoName { get; set; }
        public string GroupTime { get; set; }

        public string MentorName { get; set; }
        public Mentor Mentor { get; set; }
        public string StudentName { get; set; }
        public Student Student { get; set; }

        public string CourseName { get; set; }
        public Course Courses { get; set; }
    }
}
