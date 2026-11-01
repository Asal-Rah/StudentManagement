namespace StudentManagement
{
    partial class Form12
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
            StdPasswordTextbox = new TextBox();
            StdCreateButton = new Button();
            StdUsernameTextbox = new TextBox();
            passwordLabel = new Label();
            Usernamelabel = new Label();
            SuspendLayout();
            // 
            // StdPasswordTextbox
            // 
            StdPasswordTextbox.Location = new Point(283, 187);
            StdPasswordTextbox.Multiline = true;
            StdPasswordTextbox.Name = "StdPasswordTextbox";
            StdPasswordTextbox.Size = new Size(238, 74);
            StdPasswordTextbox.TabIndex = 2;
            // 
            // StdCreateButton
            // 
            StdCreateButton.BackColor = Color.Pink;
            StdCreateButton.Font = new Font("Lucida Calligraphy", 13.8F);
            StdCreateButton.Location = new Point(297, 332);
            StdCreateButton.Name = "StdCreateButton";
            StdCreateButton.Size = new Size(208, 91);
            StdCreateButton.TabIndex = 12;
            StdCreateButton.Text = "Create Account";
            StdCreateButton.UseVisualStyleBackColor = false;
            StdCreateButton.Click += StdCreateButton_Click;
            // 
            // StdUsernameTextbox
            // 
            StdUsernameTextbox.Location = new Point(283, 72);
            StdUsernameTextbox.Multiline = true;
            StdUsernameTextbox.Name = "StdUsernameTextbox";
            StdUsernameTextbox.Size = new Size(238, 74);
            StdUsernameTextbox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(71, 208);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(178, 39);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Password:";
            // 
            // Usernamelabel
            // 
            Usernamelabel.AutoSize = true;
            Usernamelabel.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usernamelabel.Location = new Point(50, 87);
            Usernamelabel.Name = "Usernamelabel";
            Usernamelabel.Size = new Size(199, 39);
            Usernamelabel.TabIndex = 15;
            Usernamelabel.Text = "UserName:";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Usernamelabel);
            Controls.Add(passwordLabel);
            Controls.Add(StdUsernameTextbox);
            Controls.Add(StdCreateButton);
            Controls.Add(StdPasswordTextbox);
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StdPasswordTextbox;
        private Button StdCreateButton;
        private TextBox StdUsernameTextbox;
        private Label passwordLabel;
        private Label Usernamelabel;
    }
}