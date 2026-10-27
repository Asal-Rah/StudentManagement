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

            string filePath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "LoginCredentials.txt");

            string[] userPass = File.ReadAllLines(filePath);
            bool existed = false;
            foreach(var line in userPass)
            {
                string[] userpass = line.Split(',');
                if (userpass[0].Equals(username) && userpass[1].Equals(password) )
                {
                    MessageBox.Show("This user already exists!!");
                    UsernametextBox.Text = string.Empty;
                    PasswordtextBox.Text = string.Empty;
                    existed = true;
                    break;
                    
                }
                
            }
            if(!existed)
            {
                string newAdmin = $"{Environment.NewLine}" + username + ',' + password;
                File.AppendAllText(filePath, newAdmin);
                MessageBox.Show("The new admin was created successfully!!");

            }

        }
    }
}
