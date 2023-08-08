using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Models
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseLength { get; set; }
        public int CoursePrice { get; set; }
    }
}
