﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Workforce_Silver_Snakes.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public bool IsSupervisor { get; set; }
        public int ComputerId { get; set; }
        [Display(Name = "Computer Id")]
        public Computer Computer { get; set; }
        public Department Department { get; set; }
        public List<TrainingProgram> TrainingProgram { get; set; } = new List<TrainingProgram>();
      

    }
}
