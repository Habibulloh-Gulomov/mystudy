using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Models
{
    public class Mentor
    {
        public int MentorID { get; set; }
        [MaxLength(2)]
        public int MentorAge { get; set; }
        public string MentorName { get; set; }
        public string MentorEmail { get; set; }
        public string MentorPhone { get; set; }
        public string MentorCourse { get; set; }
        public string CourseName { get; set; }
        public string MentorLevel { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set;}
    }
}
