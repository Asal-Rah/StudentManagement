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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void studentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 profile = new Form5();
            profile.ShowDialog();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 RegisterForm = new Form3();
            RegisterForm.ShowDialog();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 studentList = new Form4();
            studentList.ShowDialog();
        }

        private void addANewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 AdminCreatiion = new Form6();
            AdminCreatiion.ShowDialog();
        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 ProfRegistration = new Form7();
            ProfRegistration.ShowDialog();
        }

        private void professorsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 Proflist = new Form8();
            Proflist.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
