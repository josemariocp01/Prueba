﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace View_Models.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string area { get; set; }
    }
}
