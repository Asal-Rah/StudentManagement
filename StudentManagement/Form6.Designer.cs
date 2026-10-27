namespace StudentManagement
{
    partial class Form6
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
            CreateAdminButton = new Button();
            UsernametextBox = new TextBox();
            PasswordtextBox = new TextBox();
            AdminUsernameLabel = new Label();
            AdminPasswordLabel = new Label();
            SuspendLayout();
            // 
            // CreateAdminButton
            // 
            CreateAdminButton.BackColor = Color.Pink;
            CreateAdminButton.Font = new Font("Lucida Calligraphy", 13.8F);
            CreateAdminButton.Location = new Point(284, 304);
            CreateAdminButton.Name = "CreateAdminButton";
            CreateAdminButton.Size = new Size(192, 75);
            CreateAdminButton.TabIndex = 13;
            CreateAdminButton.Text = "Create";
            CreateAdminButton.UseVisualStyleBackColor = false;
            CreateAdminButton.Click += CreateAdminButton_Click;
            // 
            // UsernametextBox
            // 
            UsernametextBox.Location = new Point(257, 63);
            UsernametextBox.Multiline = true;
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.Size = new Size(244, 71);
            UsernametextBox.TabIndex = 14;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Location = new Point(257, 188);
            PasswordtextBox.Multiline = true;
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(244, 71);
            PasswordtextBox.TabIndex = 15;
            // 
            // AdminUsernameLabel
            // 
            AdminUsernameLabel.AutoSize = true;
            AdminUsernameLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            AdminUsernameLabel.Location = new Point(53, 81);
            AdminUsernameLabel.Name = "AdminUsernameLabel";
            AdminUsernameLabel.Size = new Size(137, 29);
            AdminUsernameLabel.TabIndex = 16;
            AdminUsernameLabel.Text = "Username";
            // 
            // AdminPasswordLabel
            // 
            AdminPasswordLabel.AutoSize = true;
            AdminPasswordLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            AdminPasswordLabel.Location = new Point(53, 214);
            AdminPasswordLabel.Name = "AdminPasswordLabel";
            AdminPasswordLabel.Size = new Size(129, 29);
            AdminPasswordLabel.TabIndex = 17;
            AdminPasswordLabel.Text = "Password";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AdminPasswordLabel);
            Controls.Add(AdminUsernameLabel);
            Controls.Add(PasswordtextBox);
            Controls.Add(UsernametextBox);
            Controls.Add(CreateAdminButton);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateAdminButton;
        private TextBox UsernametextBox;
        private TextBox PasswordtextBox;
        private Label AdminUsernameLabel;
        private Label AdminPasswordLabel;
    }
}