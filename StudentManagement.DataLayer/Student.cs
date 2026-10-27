using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer
{
    public class Student : User
    {
        public Student(string firstName, string lastName, int age, string phoneNumber, string nationalCode) : base(firstName, lastName, age, phoneNumber, nationalCode)
        {
        }
    }
}
