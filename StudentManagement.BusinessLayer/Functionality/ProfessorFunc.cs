using StudentManagement.BusinessLayer.Dtos;
using StudentManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentManagement.BusinessLayer.Functionality
{
    public class ProfessorFunc
    {

        public static bool RegisterProfessor(RegisterProfDto dto)
        {
            bool IsRegistered = false;


            //json
            Professor prof = new Professor(dto.firstName, dto.lastName, dto.age, dto.phoneNumber, dto.nationalCode, dto.card, new List<Course>());
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "Professors.json");
            string json = JsonSerializer.Serialize(prof);
            File.AppendAllText(path, json + Environment.NewLine);
            //json

            //sql 



            string connection = "Data Source=.;Initial Catalog=StudentManagement;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            string query = @"INSERT INTO Professor(firstName, lastName, age, phoneNumber, nationalCode, card)
                            values(@firstName, @lastName, @age, @phoneNumber, @nationalCode, @card)";
            
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@firstName", SqlDbType.VarChar, 100).Value = prof.firstName;
            cmd.Parameters.Add("@lastName", SqlDbType.VarChar, 100).Value = prof.lastName;
            cmd.Parameters.Add("@age", SqlDbType.Int).Value = prof.age;
            cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar, 100).Value = prof.phoneNumber;
            cmd.Parameters.Add("@nationalCode", SqlDbType.VarChar, 100).Value = prof.nationalCode;
            cmd.Parameters.Add("@card", SqlDbType.VarChar, 100).Value = prof.card;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //sql



            IsRegistered = true;
            return IsRegistered;

        }
    }
}
