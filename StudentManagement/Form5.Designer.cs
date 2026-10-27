namespace StudentManagement
{
    partial class Form5
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
            ProfilePicture = new PictureBox();
            ProfileTextBox = new TextBox();
            ProfileLastNametextBox = new TextBox();
            ProfileFirstNametextBox = new TextBox();
            ProfileButton = new Button();
            ProfileFirstNameLabel = new Label();
            ProfileLastNameLabel = new Label();
            ProfilePictureButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // ProfilePicture
            // 
            ProfilePicture.BackColor = Color.MintCream;
            ProfilePicture.Location = new Point(24, 21);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(229, 175);
            ProfilePicture.TabIndex = 0;
            ProfilePicture.TabStop = false;
            // 
            // ProfileTextBox
            // 
            ProfileTextBox.BackColor = Color.MistyRose;
            ProfileTextBox.Location = new Point(426, 21);
            ProfileTextBox.Multiline = true;
            ProfileTextBox.Name = "ProfileTextBox";
            ProfileTextBox.Size = new Size(301, 417);
            ProfileTextBox.TabIndex = 1;
            // 
            // ProfileLastNametextBox
            // 
            ProfileLastNametextBox.Location = new Point(33, 385);
            ProfileLastNametextBox.Multiline = true;
            ProfileLastNametextBox.Name = "ProfileLastNametextBox";
            ProfileLastNametextBox.Size = new Size(147, 62);
            ProfileLastNametextBox.TabIndex = 2;
            // 
            // ProfileFirstNametextBox
            // 
            ProfileFirstNametextBox.Location = new Point(33, 281);
            ProfileFirstNametextBox.Multiline = true;
            ProfileFirstNametextBox.Name = "ProfileFirstNametextBox";
            ProfileFirstNametextBox.Size = new Size(147, 62);
            ProfileFirstNametextBox.TabIndex = 3;
            // 
            // ProfileButton
            // 
            ProfileButton.BackColor = Color.Pink;
            ProfileButton.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfileButton.Location = new Point(203, 312);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(130, 87);
            ProfileButton.TabIndex = 12;
            ProfileButton.Text = "Apply ";
            ProfileButton.UseVisualStyleBackColor = false;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // ProfileFirstNameLabel
            // 
            ProfileFirstNameLabel.AutoSize = true;
            ProfileFirstNameLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfileFirstNameLabel.Location = new Point(24, 249);
            ProfileFirstNameLabel.Name = "ProfileFirstNameLabel";
            ProfileFirstNameLabel.Size = new Size(156, 29);
            ProfileFirstNameLabel.TabIndex = 13;
            ProfileFirstNameLabel.Text = "First Name";
            // 
            // ProfileLastNameLabel
            // 
            ProfileLastNameLabel.AutoSize = true;
            ProfileLastNameLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfileLastNameLabel.Location = new Point(24, 353);
            ProfileLastNameLabel.Name = "ProfileLastNameLabel";
            ProfileLastNameLabel.Size = new Size(146, 29);
            ProfileLastNameLabel.TabIndex = 14;
            ProfileLastNameLabel.Text = "Last Name";
            // 
            // ProfilePictureButton
            // 
            ProfilePictureButton.BackColor = Color.Pink;
            ProfilePictureButton.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfilePictureButton.Location = new Point(276, 21);
            ProfilePictureButton.Name = "ProfilePictureButton";
            ProfilePictureButton.Size = new Size(130, 177);
            ProfilePictureButton.TabIndex = 15;
            ProfilePictureButton.Text = "Set Picture";
            ProfilePictureButton.UseVisualStyleBackColor = false;
            ProfilePictureButton.Click += ProfilePictureButton_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProfilePictureButton);
            Controls.Add(ProfileLastNameLabel);
            Controls.Add(ProfileFirstNameLabel);
            Controls.Add(ProfileButton);
            Controls.Add(ProfileFirstNametextBox);
            Controls.Add(ProfileLastNametextBox);
            Controls.Add(ProfileTextBox);
            Controls.Add(ProfilePicture);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProfilePicture;
        private TextBox ProfileTextBox;
        private TextBox ProfileLastNametextBox;
        private TextBox ProfileFirstNametextBox;
        private Button ProfileButton;
        private Label ProfileFirstNameLabel;
        private Label ProfileLastNameLabel;
        private Button ProfilePictureButton;
    }
}