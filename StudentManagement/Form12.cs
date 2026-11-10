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
        private int _StudentId;
        public Form12(int StudentId)
        {
            InitializeComponent();
            _StudentId = StudentId;

        }

        private void StdCreateButton_Click(object sender, EventArgs e)
        {
            
           
         
            UserDto userDto = new UserDto()
            {
                userName = StdUsernameTextbox.Text,
                password = StdPasswordTextbox.Text
            };
            bool success = SharedFunc.CreateUsers(userDto, "student", _StudentId);
            if(success is false)
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
