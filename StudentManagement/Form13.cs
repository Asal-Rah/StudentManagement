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
    public partial class Form13 : Form
    {
        private string _username;
        private int _Id;
        public Form13(string username)
        {
            InitializeComponent();
            _username = username;
            _Id = FindId(_username);

        }

        public int FindId(string username)
        {
            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            string query = @"SELECT StudentId FROM StdCredentials 
                             where username = @username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            con.Open();
            int Id = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return Id;
        }

        private void coursesToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            //
        }

        private void myCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

           //


        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoursesList courseList = new CoursesList(_Id);
            courseList.Show();
        }

        private void myCoursesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MyCourse mycourse = new MyCourse(_Id);
            mycourse.Show();
        }
    }
}
