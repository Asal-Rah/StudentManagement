using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Dtos
{
    public class EnrollmentDto
    {


        public int StudentId {  get; set; } 

        public int ChosenCourseId { get; set; }
    }
}
