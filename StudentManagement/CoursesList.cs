using Microsoft.Data.SqlClient;
using StudentManagement.BusinessLayer.Dtos;
using StudentManagement.BusinessLayer.Functionality;
using StudentManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class CoursesList : Form
    {
        private string deafault;

        public CoursesList()
        {
            InitializeComponent();
            List<Course> courses = GetCourses();
            CourseListGrid.AutoGenerateColumns = true;
            CourseListGrid.DataSource = courses;
        }


        public List<Course> GetCourses()
        {
            List<Course> list = new List<Course>();
            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            string query = @"SELECT * FROM Course
                            where id in (select tc.courseid from TermCourses tc join 
                                         Term t on t.code = tc.termcode 
                                          where t.startdate > @today )";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@today", SqlDbType.DateTime).Value = DateTime.Now;
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

           
                while (reader.Read())
                {

                    SqlConnection conProf = new SqlConnection(connection);
                    string GetProf = @"SELECT firstName + ' ' + lastName from Professor where Id = @ProfessorId";
                    SqlCommand GetProfCmd = new SqlCommand(GetProf, conProf);
                    GetProfCmd.Parameters.Add("@ProfessorId", SqlDbType.Int).Value = reader.GetInt32(reader.GetOrdinal("ProfessorId"));

                    conProf.Open();

                    SqlDataReader Prof = GetProfCmd.ExecuteReader();
                    string ProfessorName = default;

                    if (Prof.Read())
                    {
                        ProfessorName = Prof.GetString(0);
                    }


                    Course course = new Course
                    {

                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        courseName = reader.GetString(reader.GetOrdinal("courseName")),
                        description = reader.GetString(reader.GetOrdinal("CourseDescription")),
                        professor = ProfessorName,
                        price = reader.GetDecimal(reader.GetOrdinal("price"))
                    };

                    list.Add(course);




                }

                if(list.Count > 0 )
                   return list;
            
            
                throw new Exception("No courses are available!!");
            


        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
           
            int ChosenCourseId = int.Parse(CourseTextBox.Text);
            string nationalCode = nationalCodeCourseTextBox.Text;

            EnrollmentDto dto = new EnrollmentDto
            {
                ChosenCourseId = ChosenCourseId,
                studentNationalCode = nationalCode
            };

            bool success = StudentFunc.enroll(dto);
            if (success)
            {
                MessageBox.Show("Enrollment registered successfully.");
            }
            else
            {
                MessageBox.Show("The enrollment process was not finished successfully!!");
            }










            



        }
    }
}
