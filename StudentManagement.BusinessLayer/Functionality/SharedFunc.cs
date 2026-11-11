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
    public class SharedFunc
    {

        public static bool CreateUsers(UserDto dto, string type, int StudentId = 0) 
        {


            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);

            con.Open();



            string tableName = type switch
            {
                "student" => "StdCredentials",
                "admin" => "AdminCredentials"
            };

            string UserCreationquery = type switch
            {
                "student" => $"INSERT INTO {tableName} (username, password, StudentId ) values ('{dto.userName}','{dto.password}',{StudentId})",
                "admin" => $"INSERT INTO {tableName}(username,password) values ('{dto.userName}','{dto.password}')"
            };
            string checkUserExistencequery = $"SELECT * FROM {tableName} where username = '{dto.userName}'";

            using (SqlCommand cmd = new SqlCommand(checkUserExistencequery,con))
            {
                object? result = cmd.ExecuteScalar(); 
                if (result is not null )
                {
                    con.Close();

                    return false;
                }
            }

            using (SqlCommand cmd = new SqlCommand(UserCreationquery, con))
            {
                cmd.ExecuteNonQuery();
                con.Close();

                return true;
            }



          

        }

        public static bool LoginUser(UserDto dto, string type)
        {



            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);





            string tableName = type switch
            {
                "student" => "StdCredentials",
                "admin" => "AdminCredentials"
            };
            string Loginquery = $"SELECT password FROM dbo.{tableName} where username = '{dto.userName}'";
            using SqlCommand cmd = new SqlCommand(Loginquery, con);
            con.Open();
            string? dbPass = Convert.ToString(cmd.ExecuteScalar());

            if (dbPass != null && dbPass.Equals(dto.password))
            {
                return true;
            }



            return false;
        }


        public static bool ChangePassword (ChangePasswordDto dto, string type)
        {
            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);

            con.Open();



            string tableName = type switch
            {
                "student" => "StdCredentials",
                "admin" => "AdminCredentials"
            };


            string checkOldPassquery = $"select password from {tableName} where username = '{dto.username}'";
            string UpdatePassquery = $"Update {tableName} set password = '{dto.NewPass}' where username = '{dto.username}'";
            using (SqlCommand cmd = new SqlCommand(checkOldPassquery, con))
            {
                string retreivedPass = Convert.ToString(cmd.ExecuteScalar());
                if (!dto.OldPass.Equals(retreivedPass))
                {
                    con.Close();
                    return false;
                }

            }

            using (SqlCommand cmd = new SqlCommand(UpdatePassquery,con))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch(Exception e )
                {
                    con.Close();
                    return false;

                }
            }
        }
    }
}
