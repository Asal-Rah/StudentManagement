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
    public partial class TermCourse : Form
    {
        public TermCourse()
        {
            InitializeComponent();

            TermCourseListGrid.AutoGenerateColumns = true;
            List<Course> courses = GetAllAvailableCourses();

            TermCourseListGrid.DataSource = courses;

        }
        public List<Course> GetAllAvailableCourses()
        {
            List<Course> list = new List<Course>();
            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            string query = @"SELECT * FROM Course";
            SqlCommand cmd = new SqlCommand(query, con);
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

            if (list.Count > 0)
                return list;


            throw new Exception("No courses are available!!");



        }

        private void TermCourseButton_Click(object sender, EventArgs e)
        {
            TermCourseDto dto = new TermCourseDto
            {
                CourseId = Convert.ToInt32(TermCourseIdTextBox.Text),
                TermCode = TermCodeCoursetextBox.Text
            };

            bool success = AdminFunc.AddCourseToTerm(dto);

            if (success)
            {
                MessageBox.Show($"The chosen course with Id {TermCourseIdTextBox.Text} was added to the term with code {TermCodeCoursetextBox.Text} ");
            }
            else
            {
                MessageBox.Show($"The chosen course with Id {TermCourseIdTextBox.Text} could not be added to the term with code {TermCodeCoursetextBox.Text}");
            }

            TermCodeCoursetextBox.Text = string.Empty;
            TermCourseIdTextBox.Text = string.Empty;
        }
    }
}
