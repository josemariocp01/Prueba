using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace View_Models.Models
{
    public class Person 
    {
        [Key]
        public string RFC { get; set; }

        [Required]
        public string Nombre { get; set; }
        public int edad { get; set; }


    }
}
