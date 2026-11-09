using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer.Enums
{
    public enum RegistrationStatus
    {

        NotRegistered = 0 , 
        reserved = 1 , //has taken the term but haven't paid yet.
        Completed = 2 
    }
}
