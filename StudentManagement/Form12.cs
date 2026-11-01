using StudentManagement.BusinessLayer.Dtos;
using StudentManagement.BusinessLayer.Functionality;
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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void StdCreateButton_Click(object sender, EventArgs e)
        {
            Form3 RegForm = new Form3();
            RegForm.ShowDialog();
           
         
            UserDto userDto = new UserDto()
            {
                userName = StdUsernameTextbox.Text,
                password = StdPasswordTextbox.Text
            };
            string filePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "StdLoginCredentials.txt");

            bool alreadyExisted = CreateUser.CreateUsers(userDto, filePath);
            if(alreadyExisted)
            {
                MessageBox.Show("This student already exists!!");
                StdUsernameTextbox.Text = string.Empty;
                StdPasswordTextbox.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("The new student user was created successfully!!");
            }

        }
    }
}
