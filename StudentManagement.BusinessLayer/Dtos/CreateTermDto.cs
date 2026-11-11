using StudentManagement.DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Dtos
{
    public class CreateTermDto
    {

        public string TermCode { get; set; }
        public int Termseason { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
