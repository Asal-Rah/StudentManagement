using Newtonsoft.Json;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            listProfessors();
        }

        public void listProfessors()
        {
            List<Professor> Profs = new List<Professor>();

            Profs = GetProfessors();
            ProfListGrid.AutoGenerateColumns = true;
            ProfListGrid.DataSource = Profs;



        }

        public static List<Professor> GetProfessors(string name = null, string lastname = null)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "Professors.json");
            List<Professor> list = new List<Professor>();
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    if (String.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    Professor? prof = JsonConvert.DeserializeObject<Professor>(line);
                    if (prof != null)
                    {
                        if (name == null & lastname == null)
                        {
                            list.Add(prof);
                            continue;
                        }
                        else if (!String.IsNullOrEmpty(name))
                        {
                            if (prof.firstName != name)
                            {
                                continue;
                            }
                        }
                        else if (!String.IsNullOrEmpty(lastname))
                        {
                            if (prof.lastName != lastname)
                            {
                                continue;
                            }
                        }

                        list.Add(prof);



                    }


                }
                return list;
            }
            else
            {
                throw new Exception("No Professor could be found!!");

            }

        }

        private void StudentListGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProfFilterButton_Click(object sender, EventArgs e)
        {
            List<Professor> Profs = new List<Professor>();
            Profs = GetProfessors(ProfFirstNameFilter.Text, ProfLastNameFilter.Text);
            ProfListGrid.AutoGenerateColumns = true;
            ProfListGrid.DataSource = Profs;


        }
    }
}
