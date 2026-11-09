using StudentManagement.DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer
{
    public class Enrollment
    {

        public int Id { get; set; }
        public int StudentId { get; set; }
        public RegistrationStatus registrationStatus { get; set; }
        public string TermCode { get; set; }



    }
}
