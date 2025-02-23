﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CPW219_CRUD_Troubleshooting.Models
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        [DefaultValue(null)]
        public DateTime DateOfBirth { get; set; }
    }
}
