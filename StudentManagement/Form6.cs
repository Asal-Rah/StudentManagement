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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void CreateAdminButton_Click(object sender, EventArgs e)
        {
            string username = UsernametextBox.Text;
            string password = PasswordtextBox.Text;

            UserDto adminDto = new UserDto()
            {
                userName = UsernametextBox.Text,
                password = PasswordtextBox.Text
            };
            string filePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "LoginCredentials.txt");

            bool alreadyExisted = CreateUser.CreateUsers(adminDto, filePath);


            if (alreadyExisted)
            {
                MessageBox.Show("This user already exists!!");
                UsernametextBox.Text = string.Empty;
                PasswordtextBox.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("The new admin was created successfully!!");
            }

        }
    }
}
