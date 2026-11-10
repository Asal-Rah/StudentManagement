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
    public partial class Form3 : Form
    {
        private string _type;
        public Form3()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
          

            RegisterStudentDto studentDto = new RegisterStudentDto()
            {
                firstName = FisrtNametextBox.Text,
                lastName = LastNametextBox.Text,
                age = Convert.ToInt32(AgetextBox.Text), 
                phoneNumber = PhoneNumbertextBox.Text.ToMoblieFormat(),
                nationalCode = NationalCodetextBox.Text
            };
            bool success = StudentFunc.RegisterStudents(studentDto);
        
            FisrtNametextBox.Text = string.Empty;
            LastNametextBox.Text = string.Empty;
            AgetextBox.Text = string.Empty;
            PhoneNumbertextBox.Text = string.Empty;
            NationalCodetextBox.Text = string.Empty;
            if (success)
            {
                MessageBox.Show("The student was registered successfully!!");
                int StudentId = StudentFunc.FindIdByNationalCode(studentDto.nationalCode);
                Form12 createStAccount = new Form12(StudentId);
                createStAccount.ShowDialog();
            }
            else
            {
                MessageBox.Show("The registeration process was abrupted unexpectedly! Please try again!!");
            }

            







        }
    }
}
