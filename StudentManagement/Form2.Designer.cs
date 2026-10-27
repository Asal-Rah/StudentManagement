namespace StudentManagement
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homePage = new ToolStripMenuItem();
            studentsToolStripMenuItem1 = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            studentListToolStripMenuItem = new ToolStripMenuItem();
            adminsToolStripMenuItem = new ToolStripMenuItem();
            addANewAdminToolStripMenuItem = new ToolStripMenuItem();
            professorsToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem1 = new ToolStripMenuItem();
            professorsListToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homePage, adminsToolStripMenuItem, professorsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homePage
            // 
            homePage.BackColor = Color.MistyRose;
            homePage.DropDownItems.AddRange(new ToolStripItem[] { studentsToolStripMenuItem1, registerToolStripMenuItem, studentListToolStripMenuItem });
            homePage.Font = new Font("Lucida Calligraphy", 13.8F);
            homePage.Name = "homePage";
            homePage.Size = new Size(129, 33);
            homePage.Text = "Students";
            // 
            // studentsToolStripMenuItem1
            // 
            studentsToolStripMenuItem1.Name = "studentsToolStripMenuItem1";
            studentsToolStripMenuItem1.Size = new Size(244, 34);
            studentsToolStripMenuItem1.Text = "Profile";
            studentsToolStripMenuItem1.Click += studentsToolStripMenuItem1_Click;
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(244, 34);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // studentListToolStripMenuItem
            // 
            studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            studentListToolStripMenuItem.Size = new Size(244, 34);
            studentListToolStripMenuItem.Text = "Student List";
            studentListToolStripMenuItem.Click += studentListToolStripMenuItem_Click;
            // 
            // adminsToolStripMenuItem
            // 
            adminsToolStripMenuItem.BackColor = Color.MistyRose;
            adminsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addANewAdminToolStripMenuItem });
            adminsToolStripMenuItem.Font = new Font("Lucida Calligraphy", 13.8F);
            adminsToolStripMenuItem.Name = "adminsToolStripMenuItem";
            adminsToolStripMenuItem.Size = new Size(123, 33);
            adminsToolStripMenuItem.Text = "Admins";
            // 
            // addANewAdminToolStripMenuItem
            // 
            addANewAdminToolStripMenuItem.Name = "addANewAdminToolStripMenuItem";
            addANewAdminToolStripMenuItem.Size = new Size(320, 34);
            addANewAdminToolStripMenuItem.Text = "Add a new admin";
            addANewAdminToolStripMenuItem.Click += addANewAdminToolStripMenuItem_Click;
            // 
            // professorsToolStripMenuItem
            // 
            professorsToolStripMenuItem.BackColor = Color.MistyRose;
            professorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profileToolStripMenuItem, registerToolStripMenuItem1, professorsListToolStripMenuItem });
            professorsToolStripMenuItem.Font = new Font("Lucida Calligraphy", 13.8F);
            professorsToolStripMenuItem.Name = "professorsToolStripMenuItem";
            professorsToolStripMenuItem.Size = new Size(148, 33);
            professorsToolStripMenuItem.Text = "Professors";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(273, 34);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // registerToolStripMenuItem1
            // 
            registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            registerToolStripMenuItem1.Size = new Size(273, 34);
            registerToolStripMenuItem1.Text = "Register";
            registerToolStripMenuItem1.Click += registerToolStripMenuItem1_Click;
            // 
            // professorsListToolStripMenuItem
            // 
            professorsListToolStripMenuItem.Name = "professorsListToolStripMenuItem";
            professorsListToolStripMenuItem.Size = new Size(273, 34);
            professorsListToolStripMenuItem.Text = "Professors List";
            professorsListToolStripMenuItem.Click += professorsListToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homePage;
        private ToolStripMenuItem studentsToolStripMenuItem1;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem studentListToolStripMenuItem;
        private ToolStripMenuItem adminsToolStripMenuItem;
        private ToolStripMenuItem addANewAdminToolStripMenuItem;
        private ToolStripMenuItem professorsToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem1;
        private ToolStripMenuItem professorsListToolStripMenuItem;
    }
}