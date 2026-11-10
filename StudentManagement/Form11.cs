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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void HaveButton_Click(object sender, EventArgs e)
        {
            string type = "student";
            Form1 LoginForm = new Form1(type);
            LoginForm.ShowDialog();
        }

        private void DontHaveButton_Click(object sender, EventArgs e)
        {

            Form3 SignUp = new Form3();
            SignUp.ShowDialog();



        }
    }
}
