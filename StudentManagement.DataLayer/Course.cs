using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer
{
    public class Course
    {

        public int Id {  get; set; }
        public string courseName {  get; set; }
        public string description   { get; set; }
        public string professor { get; set; }

        public decimal price { get; set; }
        
    }
}
