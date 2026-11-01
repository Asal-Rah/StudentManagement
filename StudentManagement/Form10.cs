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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void WelcomePageButton_Click(object sender, EventArgs e)
        {
            Form11 StdWelcome = new Form11();
            StdWelcome.ShowDialog();

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void WelcomeNoButton_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "files", "LoginCredentials.txt");
            string type = "admin";
            Form1 AdminLogin = new Form1(path, type);
            AdminLogin.ShowDialog();


        }
    }
}
