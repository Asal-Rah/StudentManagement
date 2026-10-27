using Newtonsoft.Json;
using StudentManagement.DataLayer;
using System;
using System.Collections;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            listOfStudents();
        }

        public void listOfStudents()
        {
            /*string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "Students.json");
            List<Student> list = new List<Student>();
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    if (String.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    Student? std = JsonConvert.DeserializeObject<Student>(line);
                    if (std != null)
                    {
                        list.Add(std);
                    }
                    StudentListGrid.AutoGenerateColumns = true;
                    StudentListGrid.DataSource = list;

                }
            }
            else
            {
                throw new Exception("No student could be found!!");

            }*/

            List<Student> students = new List<Student>();
            students = GetStudents();
            StudentListGrid.AutoGenerateColumns = true;
            StudentListGrid.DataSource = students;

        }

        public static List<Student> GetStudents(string name = null , string lastname = null , string nationalcode = null)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "Students.json");
            List<Student> list = new List<Student>();
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    if (String.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    Student? std = JsonConvert.DeserializeObject<Student>(line);
                    if (std != null)
                    {
                        if (name == null & lastname == null & nationalcode == null)
                        {
                            list.Add(std);
                            continue;
                        }
                        else if (!String.IsNullOrEmpty(name))
                        {
                            if (std.firstName != name)
                            {
                                continue;
                            }
                        }
                        else if (!String.IsNullOrEmpty(lastname))
                        {
                            if (std.lastName != lastname)
                            {
                                continue;
                            }
                        }
                        else if (!String.IsNullOrEmpty(nationalcode))
                        {
                            if(std.nationalCode != nationalcode)
                            {
                                continue;
                            }
                        }
                        list.Add(std);
                        
                        
                        
                    }
                    

                }
                return list;
            }
            else
            {
                throw new Exception("No student could be found!!");

            }
            
        }
             
        private void FilterButton_Click(object sender, EventArgs e)
        {
            StudentListGrid.DataSource = null;
            string firstName = NameFilter.Text;

            string lastName = LastNameFilter.Text;
            string nationalCode = NationalCodeFilter.Text;
            List<Student> students = new List<Student>();
            students = GetStudents(firstName, lastName, nationalCode);

            StudentListGrid.AutoGenerateColumns = true;
            StudentListGrid.DataSource = students;


        }
    }
}
