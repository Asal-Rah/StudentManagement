namespace StudentManagement
{
    partial class ChangePassword
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
            OldPassTextbox = new TextBox();
            NewPasstextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            UpdatePasswordButton = new Button();
            SuspendLayout();
            // 
            // OldPassTextbox
            // 
            OldPassTextbox.Location = new Point(271, 81);
            OldPassTextbox.Multiline = true;
            OldPassTextbox.Name = "OldPassTextbox";
            OldPassTextbox.Size = new Size(197, 74);
            OldPassTextbox.TabIndex = 15;
            // 
            // NewPasstextBox
            // 
            NewPasstextBox.Location = new Point(271, 188);
            NewPasstextBox.Multiline = true;
            NewPasstextBox.Name = "NewPasstextBox";
            NewPasstextBox.Size = new Size(197, 74);
            NewPasstextBox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 13.8F);
            label2.Location = new Point(67, 100);
            label2.Name = "label2";
            label2.Size = new Size(184, 29);
            label2.TabIndex = 19;
            label2.Text = "Old Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 13.8F);
            label1.Location = new Point(50, 210);
            label1.Name = "label1";
            label1.Size = new Size(201, 29);
            label1.TabIndex = 20;
            label1.Text = "New Password:";
            // 
            // UpdatePasswordButton
            // 
            UpdatePasswordButton.BackColor = Color.Pink;
            UpdatePasswordButton.Font = new Font("Lucida Calligraphy", 13.8F);
            UpdatePasswordButton.Location = new Point(258, 316);
            UpdatePasswordButton.Name = "UpdatePasswordButton";
            UpdatePasswordButton.Size = new Size(224, 74);
            UpdatePasswordButton.TabIndex = 23;
            UpdatePasswordButton.Text = "Change Password";
            UpdatePasswordButton.UseVisualStyleBackColor = false;
            UpdatePasswordButton.Click += UpdatePasswordButton_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdatePasswordButton);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(NewPasstextBox);
            Controls.Add(OldPassTextbox);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OldPassTextbox;
        private TextBox NewPasstextBox;
        private Label label2;
        private Label label1;
        private Button UpdatePasswordButton;
    }
}