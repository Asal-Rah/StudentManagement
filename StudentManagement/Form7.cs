using StudentManagement.BusinessLayer.Dtos;
using StudentManagement.BusinessLayer.Extensions;
using StudentManagement.BusinessLayer.Functionality;
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
            

            RegisterProfDto dto = new RegisterProfDto()
            {
               firstName = ProfNametextBox.Text,
               lastName = ProfLastNametextBox.Text,
               age = Convert.ToInt32(ProfAgetextBox.Text),
               phoneNumber = ProfPhonetextBox.Text.ToMoblieFormat(),
               nationalCode = ProfNarionalCodetextBox.Text,
               card = ProfCardtextBox.Text
            };

            bool success = ProfessorFunc.RegisterProfessor(dto);
            ProfNametextBox.Text = string.Empty;
            ProfLastNametextBox.Text = string.Empty;
            ProfAgetextBox.Text = string.Empty;
            ProfPhonetextBox.Text = string.Empty;
            ProfNarionalCodetextBox.Text = string.Empty;
            ProfCardtextBox.Text = string.Empty; ;
            if (success)
            {
                MessageBox.Show("The professor was registered successfully!!");
            }
            else
            {
                throw new Exception("The registeration process was abrupted unexpectedly! Please try again!!");
            }

        }
    }
}
