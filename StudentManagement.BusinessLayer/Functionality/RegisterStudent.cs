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
    public class RegisterStudent
    {

        public static bool RegisterStudents(RegisterStudentDto dto)
        {
            bool IsRegistered = false;
            Student student = new Student(dto.firstName, dto.lastName, dto.age, dto.phoneNumber, dto.nationalCode);
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "Students.json");
            

            string json = JsonSerializer.Serialize(student);
            File.AppendAllText(path, json + Environment.NewLine);
            IsRegistered = true;
            return IsRegistered;
            
        }
    }
}
