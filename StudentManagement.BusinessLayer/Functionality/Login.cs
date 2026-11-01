using StudentManagement.BusinessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Functionality
{
    public class Login
    {
        public static bool LoginUser(UserDto dto, string path)
        {
            string[] credentials = File.ReadAllLines(path);
            bool valid = default;
            foreach (var line in credentials)
            {

                string[] userPass = line.Split(',');
                if (userPass[0] == dto.userName && userPass[1] == dto.password)
                {
                    valid = true;
                    break;
                }

            }
            return valid;
        }
    }
}
