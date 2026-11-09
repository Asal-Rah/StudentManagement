using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer
{
    public class TermCourses
    {
        public int Id { get; set; }

        public string code { get; set; }

        public List<Course> IncludedCourses { get; set; }

    }
}
