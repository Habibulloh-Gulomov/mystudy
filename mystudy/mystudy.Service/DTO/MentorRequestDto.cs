using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class MentorRequestDto
    {

        [Required]
        [MaxLength(5)]
        public string MentorName { get; set; }
        [Required]

        public string MentorCourse { get; set; }
 
    }
}
