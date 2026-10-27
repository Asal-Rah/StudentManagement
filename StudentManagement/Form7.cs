using StudentManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string firstName = ProfNametextBox.Text;
            string lastName = ProfLastNametextBox.Text;
            int Age = Convert.ToInt32(ProfAgetextBox.Text);
            string phoneNumber = ProfPhonetextBox.Text;
            string nationalCode = ProfNarionalCodetextBox.Text;
            string card = ProfCardtextBox.Text;

            Professor prof = new Professor(firstName, lastName, Age, phoneNumber, nationalCode, card);
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "Professors.json");
            string json = JsonSerializer.Serialize(prof);
            File.AppendAllText(path, json + Environment.NewLine);
            ProfNametextBox.Text = string.Empty;
            ProfLastNametextBox.Text = string.Empty;
            ProfAgetextBox.Text = string.Empty;
            ProfPhonetextBox.Text = string.Empty;
            ProfNarionalCodetextBox.Text = string.Empty;
            ProfCardtextBox.Text = string.Empty; ;
            MessageBox.Show("The new Professor has been successfully registered!!");

        }
    }
}
