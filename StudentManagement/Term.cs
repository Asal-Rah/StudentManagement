using StudentManagement.BusinessLayer.Dtos;
using StudentManagement.BusinessLayer.Functionality;
using StudentManagement.DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace StudentManagement
{
    public partial class Term : Form
    {
        public Term()
        {
            InitializeComponent();
        }

        private void CreateTermButton_Click(object sender, EventArgs e)
        {
            int seasonId = 10;
            if (Enum.TryParse<TermSeason>(
                    TermSeasontextBox.Text.Trim(),
                    ignoreCase: true,
                    out TermSeason season))
            {
                seasonId = (int)season;
            }
            CreateTermDto dto = new CreateTermDto
            {
                TermCode = TermCodeTextbox.Text,
                Termseason = seasonId,
                StartDate = TermStarttextBox.Text,
                EndDate = TermEndtextBox.Text

            };

            bool success = AdminFunc.DefineTerm(dto);

            if (success)
            {
                MessageBox.Show("The term was created successfully!!");

            }
            else
            {
                MessageBox.Show("The term could not be created at this moment!!");


            }

            TermCodeTextbox.Text = string.Empty;
            TermSeasontextBox.Text = string.Empty;
            TermStarttextBox.Text = string.Empty;
            TermEndtextBox.Text = string.Empty;

            TermCourse tc = new TermCourse();
            tc.ShowDialog();
        }
    }
}
