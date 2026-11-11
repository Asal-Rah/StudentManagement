using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Dtos
{
    public class ChangePasswordDto
    {
        public string OldPass {  get; set; }
        public string NewPass { get; set; }

        public string username { get; set; }
    }
}
