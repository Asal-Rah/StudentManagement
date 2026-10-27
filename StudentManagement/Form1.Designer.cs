namespace StudentManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            Usernamelabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(254, 95);
            usernameTextBox.Multiline = true;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(261, 55);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(254, 192);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(261, 55);
            passwordTextBox.TabIndex = 1;
            // 
            // Usernamelabel
            // 
            Usernamelabel.AutoSize = true;
            Usernamelabel.Font = new Font("Lucida Calligraphy", 13.8F);
            Usernamelabel.Location = new Point(67, 110);
            Usernamelabel.Name = "Usernamelabel";
            Usernamelabel.Size = new Size(151, 29);
            Usernamelabel.TabIndex = 2;
            Usernamelabel.Text = "UserName:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(83, 204);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(135, 29);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Pink;
            loginButton.Font = new Font("Lucida Calligraphy", 13.8F);
            loginButton.Location = new Point(286, 308);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(192, 50);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(Usernamelabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label Usernamelabel;
        private Label passwordLabel;
        private Button loginButton;
    }
}
