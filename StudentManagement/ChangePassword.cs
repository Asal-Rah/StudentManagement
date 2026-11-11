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
    public partial class ChangePassword : Form
    {

        private string _type;
        private string _username; 
        public ChangePassword(string type , string username)
        {
            _type = type;
            _username = username;
            InitializeComponent();
        }

        private void UpdatePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordDto dto = new ChangePasswordDto
            {
                NewPass = NewPasstextBox.Text,
                OldPass = OldPassTextbox.Text,
                username = _username
            };

            bool success = SharedFunc.ChangePassword(dto, _type);
            if(success)
            {
                MessageBox.Show("Password was updated successfully!");
            }
            else
            {
                MessageBox.Show("Couldn't update the password.");
            }

            NewPasstextBox.Text = string.Empty;
            OldPassTextbox.Text = string.Empty;
        }
    }
}
