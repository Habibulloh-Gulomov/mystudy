using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class StudentRequestDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set;}

        [Required]
        [MinLength(9)]
        [MaxLength(9)]
        public string Phone { get; set;}

        [Required]
        public bool isPaid { get; set;}

    }
}
