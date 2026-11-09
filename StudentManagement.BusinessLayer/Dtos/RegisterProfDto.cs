using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Dtos
{
    public class RegisterProfDto
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string phoneNumber { get; set; }
        public string nationalCode { get; set; }
        public string card { get; set; }

    }
}
