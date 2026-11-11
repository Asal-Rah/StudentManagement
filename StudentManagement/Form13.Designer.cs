namespace StudentManagement
{
    partial class Form13
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
            coursesToolStripMenuItem = new ToolStripMenuItem();
            myCoursesToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { coursesToolStripMenuItem, myCoursesToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.BackColor = Color.MistyRose;
            coursesToolStripMenuItem.Font = new Font("Lucida Calligraphy", 13.8F);
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(117, 33);
            coursesToolStripMenuItem.Text = "Courses";
            coursesToolStripMenuItem.Click += coursesToolStripMenuItem_Click;
            // 
            // myCoursesToolStripMenuItem
            // 
            myCoursesToolStripMenuItem.BackColor = Color.MistyRose;
            myCoursesToolStripMenuItem.Font = new Font("Lucida Calligraphy", 13.8F);
            myCoursesToolStripMenuItem.Name = "myCoursesToolStripMenuItem";
            myCoursesToolStripMenuItem.Size = new Size(168, 33);
            myCoursesToolStripMenuItem.Text = "My Courses";
            myCoursesToolStripMenuItem.Click += myCoursesToolStripMenuItem_Click_1;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.BackColor = Color.MistyRose;
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem });
            accountToolStripMenuItem.Font = new Font("Lucida Calligraphy", 13.8F);
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(130, 33);
            accountToolStripMenuItem.Text = "Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(312, 34);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form13";
            Text = "Form13";
            Load += Form13_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem myCoursesToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}