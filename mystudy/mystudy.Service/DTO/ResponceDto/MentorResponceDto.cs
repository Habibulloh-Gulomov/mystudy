using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO.ResponceDto
{
    internal class MentorResponceDto
    {
        [Required]
        public int MentorID { get; set; }
        [Required]
        public int MentorAge { get; set; }
        [Required]
        public string MentorName { get; set; }
        [Required]
        public string MentorEmail { get; set; }
        [Required]
        public string MentorPhone { get; set; }
        [Required]
        public string MentorCourse { get; set; }
        [Required]       
        public string MentorLevel { get; set; }    
        
    }
}
