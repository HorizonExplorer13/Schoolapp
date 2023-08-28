﻿using System.ComponentModel.DataAnnotations;

namespace SchoolApp.DTO
{
    public class StudentDataCreation
    {
        [Required]
        public int Document { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Direction { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
