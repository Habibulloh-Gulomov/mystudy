using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    internal class StudentResponseDTO
    {
        [Required]
        public string StudentName { get; set; }

        [Required]
        public int StudentAge { get; set; }

        public string StudentGender { get; set; }

        [Required]
        [MinLength(9)]
        [MaxLength(9)]
        public int StudentPhone { get; set; }

        public string StudentEmail { get; set; }
    }
}
