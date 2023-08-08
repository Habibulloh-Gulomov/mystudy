using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Models
{
    public class Mentor
    {
        public int MentorID { get; set; }
        
        public int MentorAge { get; set; }

        public string MentorName { get; set; }

        public string MentorEmail { get; set; }

        public string MentorPhone { get; set; }

        public string MentorCourse { get; set; }

        public string CourseName { get; set; }

        public string MentorLevel { get; set; }

        public string StudentName { get; set; }

        public string StudentEmail { get; set; }
    }
}
