using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorUas_72190277.Models
{
    public class Student
    {
        public string studentID { get; set; }

        [Required]
        public string lastName { get; set; }
        [Required]
        public string firstName { get; set; }

        public DateTime enrollmentDate { get; set; }
    }
}