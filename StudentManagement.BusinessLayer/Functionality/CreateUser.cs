using StudentManagement.BusinessLayer.Dtos;
using StudentManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Functionality
{
    public class CreateUser
    {

        public static bool CreateUsers(UserDto dto, string filePath)
        {
            

            

            string[] userPass = File.ReadAllLines(filePath);
            bool existed = false;
            foreach (var line in userPass)
            {
                string[] userpass = line.Split(',');
                if (userpass[0].Equals(dto.userName) && userpass[1].Equals(dto.password))
                {
                   
                    existed = true;
                    break;
                    

                }

            }
            if (!existed)
            {
                string newAdmin = $"{Environment.NewLine}" + dto.userName + ',' + dto.password;
                File.AppendAllText(filePath, newAdmin);
                


            }
            return existed;

        }
    }
}
