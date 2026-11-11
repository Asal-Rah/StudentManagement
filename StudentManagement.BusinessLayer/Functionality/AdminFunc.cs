using StudentManagement.BusinessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BusinessLayer.Functionality
{
    public class AdminFunc
    {

        public static bool DefineTerm(CreateTermDto dto)
        {
            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            string CreateTermquery = $"INSERT INTO Term (code, startdate, enddate, termseason) values ('{dto.TermCode}','{dto.StartDate}','{dto.EndDate}',{dto.Termseason})";

            con.Open();

            using (SqlCommand cmd = new SqlCommand(CreateTermquery, con))
            {

                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch (Exception e )
                {
                    con.Close();
                    return false;
                    //throw new Exception("Term could not be created at this moment!!");
                    
                }
            }


        }


        public static bool AddCourseToTerm(TermCourseDto dto)
        {
            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);

            string AddCourseTermquery = $"INSERT INTO TermCourses (termcode,courseId) values ('{dto.TermCode}',{dto.CourseId}) ";
            con.Open();
            using (SqlCommand cmd = new SqlCommand(AddCourseTermquery,con))
            {

                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch(Exception e)
                {
                    con.Close();
                    return false;

                }
            }
        }
    }
}
