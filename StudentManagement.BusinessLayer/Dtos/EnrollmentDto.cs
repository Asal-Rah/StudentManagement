using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Dtos
{
    public class EnrollmentDto
    {


        public string studentNationalCode {  get; set; } 

        public int ChosenCourseId { get; set; }
    }
}
