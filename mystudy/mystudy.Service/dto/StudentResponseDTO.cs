﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTO
{
    public class StudentResponseDTO
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public enum Gender { man, women }

        public int Phone { get; set; }

        public string Email { get; set; }
    }
}
