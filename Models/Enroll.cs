using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blazorUas_72190277.Models
{
    public class Enroll
    {
        public string studentID { get; set; }

        public string lastName { get; set; }

        public string firstName { get; set; }

        public Student Student{ get; set; }

        public DateTime enrollmentDate { get; set; }

        public int enrollmentID { get; set; }

        public string grade { get; set; }

        public int courseID { get; set; }

        public string title { get; set; }

        public int credits { get; set; }
    }
}