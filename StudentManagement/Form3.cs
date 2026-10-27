using StudentManagement.BusinessLayer.Extensions;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(FisrtNametextBox.Text, LastNametextBox.Text, Convert.ToInt32(AgetextBox.Text), PhoneNumbertextBox.Text.ToMoblieFormat(), NationalCodetextBox.Text);
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "Students.json");
            /*var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };*/
            
            string json = JsonSerializer.Serialize(student);
            File.AppendAllText(path, json + Environment.NewLine);
            //File.AppendAllText(path, json);
            FisrtNametextBox.Text = string.Empty;
            LastNametextBox.Text = string.Empty;
            AgetextBox.Text = string.Empty;
            PhoneNumbertextBox.Text = string.Empty;
            NationalCodetextBox.Text = string.Empty;
            MessageBox.Show("The student was registered successfully!!");






        }
    }
}
