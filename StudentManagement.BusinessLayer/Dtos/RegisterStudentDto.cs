using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Dtos
{
    public class RegisterStudentDto
    {


        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string phoneNumber { get; set; }
        public string nationalCode { get; set; }

    }
}
