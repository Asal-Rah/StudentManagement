global using Microsoft.Data.SqlClient;
using StudentManagement.BusinessLayer.Dtos;
using StudentManagement.DataLayer;
using StudentManagement.DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace StudentManagement.BusinessLayer.Functionality
{
    public class StudentFunc
    {

        public static bool RegisterStudents(RegisterStudentDto dto)
        {
            bool IsRegistered = false;

            if (CheckStudentExistence(dto))
            {
                return IsRegistered;
            }


            Student student = new Student(dto.firstName, dto.lastName, dto.age, dto.phoneNumber, dto.nationalCode);
            //json
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "Students.json");
            string json = JsonSerializer.Serialize(student);
            File.AppendAllText(path, json + Environment.NewLine);
            //json

            //sql
            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            string query = @"INSERT INTO Student (firstName, lastName, age, phoneNumber, nationalCode)
                            values (@firstName, @lastName, @age, @phoneNumber, @nationalCode)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 100).Value = student.firstName;
            cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 100).Value = student.lastName;
            cmd.Parameters.Add("@age", SqlDbType.Int).Value = student.age;
            cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar, 100).Value = student.phoneNumber;
            cmd.Parameters.Add("@nationalCode", SqlDbType.VarChar, 100).Value = student.nationalCode;
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
            //sql

            IsRegistered = true;

            return IsRegistered;

            
        }


        public static bool CheckStudentExistence(RegisterStudentDto dto)
        {
            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string StudentExistencequery = $"SELECT Id from Student where nationalcode = {dto.nationalCode}";


            using (SqlCommand cmd = new SqlCommand(StudentExistencequery,con))
            {
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result != 0 )
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }


        }


        public static bool enroll(EnrollmentDto dto)
        {
            try
            {
                string termCode = "";
                int studentId = dto.StudentId;
                int existed = 0; 


                string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                string termquery = @"select code from Term where startDate > @today";
                string studentquery = "Select Id from Student where nationalCode = @nationalcode ";
                string enrollquery = @"INSERT INTO Enrollment (StudentId, RegistrationStatus, TermCode) values ( @StudentId , @RegisterStatus , @termcode) ";
                string StudentCoursequery = @"INSERT INTO StudentTakenCourses (StudentId, CourseId, termcode) values (@StudentId , @CourseId, @termcode)";
                string checkExistence = @"select 1 from StudentTakenCourses stc where courseId = @CourseId  and termcode = @termcode ";
                bool alreadyEnrolledTerm = false;


                using (SqlCommand cmd = new SqlCommand(termquery, con))
                {
                    cmd.Parameters.Add("@today", SqlDbType.DateTime).Value = DateTime.Now;
                    termCode = Convert.ToString(cmd.ExecuteScalar());


                }
                string checkEnrollment = $"select 1 from Enrollment where studentId = {studentId} and termcode = '{termCode}'";


                using (SqlCommand cmd = new SqlCommand(checkExistence, con))
                {
                    cmd.Parameters.Add("@CourseId", SqlDbType.VarChar).Value = dto.ChosenCourseId;
                    cmd.Parameters.Add("@termcode", SqlDbType.VarChar).Value = termCode;
                    existed  = Convert.ToInt32(cmd.ExecuteScalar());
                    if(existed == 1 ) { return false;  }


                }

                using (SqlCommand cmd = new SqlCommand(checkEnrollment, con))
                {
                    object? result = cmd.ExecuteScalar();
                    if (result is not null)
                    {
                        alreadyEnrolledTerm = true;
                    }
                }

                if (!alreadyEnrolledTerm)
                    {
                        using (SqlCommand cmd = new SqlCommand(enrollquery, con))
                        {

                            cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
                            cmd.Parameters.Add("@termcode", SqlDbType.VarChar).Value = termCode;
                            cmd.Parameters.Add("@RegisterStatus", SqlDbType.Int).Value = RegistrationStatus.reserved;

                            cmd.ExecuteNonQuery();

                        }
                    }

                using (SqlCommand cmd = new SqlCommand(StudentCoursequery, con))
                {
                    cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentId;
                    cmd.Parameters.Add("@termcode", SqlDbType.VarChar).Value = termCode;
                    cmd.Parameters.Add("@CourseId", SqlDbType.VarChar).Value = dto.ChosenCourseId;

                    cmd.ExecuteNonQuery();

                }


                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }

        public static int FindIdByNationalCode(string nationalCode)
        {
            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            string query = $"SELECT Id FROM Student where nationalCode = {nationalCode}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int Id = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return Id;
        }
    }
}
