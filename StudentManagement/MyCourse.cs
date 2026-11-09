using Microsoft.Data.SqlClient;
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
    public partial class MyCourse : Form
    {
        private int _Id; 
        public MyCourse(int Id)
        {
            InitializeComponent();
            _Id = Id;

            List<Course> list = GetMyCourse(_Id);
            MyCourseListGrid.AutoGenerateColumns = true;
            MyCourseListGrid.DataSource = list;


        }

        public List<Course> GetMyCourse(int Id)
        {
            List<Course> list = new List<Course>();
            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            string query = @"SELECT c.* FROM StudentTakenCourses stc 
                            join Course c on c.Id = stc.CourseId 
                            where StudentId = @StudentId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@StudentId", SqlDbType.Int).Value = Id;
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

        private void CourseListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
