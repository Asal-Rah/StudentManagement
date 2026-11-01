namespace StudentManagement
{
    partial class Form9
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
            ProfProfileTextBox = new TextBox();
            ProfProfilePicture = new PictureBox();
            ProfilePictureButton = new Button();
            ProfProfileFirstNametextBox = new TextBox();
            ProfProfileLastNameTextbox = new TextBox();
            ProfileButton = new Button();
            ProfileFirstNameLabel = new Label();
            ProfileLastNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ProfProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // ProfProfileTextBox
            // 
            ProfProfileTextBox.BackColor = Color.MistyRose;
            ProfProfileTextBox.Location = new Point(449, 21);
            ProfProfileTextBox.Multiline = true;
            ProfProfileTextBox.Name = "ProfProfileTextBox";
            ProfProfileTextBox.Size = new Size(301, 417);
            ProfProfileTextBox.TabIndex = 2;
            // 
            // ProfProfilePicture
            // 
            ProfProfilePicture.BackColor = Color.MintCream;
            ProfProfilePicture.Location = new Point(27, 21);
            ProfProfilePicture.Name = "ProfProfilePicture";
            ProfProfilePicture.Size = new Size(229, 175);
            ProfProfilePicture.TabIndex = 3;
            ProfProfilePicture.TabStop = false;
            // 
            // ProfilePictureButton
            // 
            ProfilePictureButton.BackColor = Color.Pink;
            ProfilePictureButton.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfilePictureButton.Location = new Point(285, 21);
            ProfilePictureButton.Name = "ProfilePictureButton";
            ProfilePictureButton.Size = new Size(130, 177);
            ProfilePictureButton.TabIndex = 16;
            ProfilePictureButton.Text = "Set Picture";
            ProfilePictureButton.UseVisualStyleBackColor = false;
            ProfilePictureButton.Click += ProfilePictureButton_Click;
            // 
            // ProfProfileFirstNametextBox
            // 
            ProfProfileFirstNametextBox.Location = new Point(43, 270);
            ProfProfileFirstNametextBox.Multiline = true;
            ProfProfileFirstNametextBox.Name = "ProfProfileFirstNametextBox";
            ProfProfileFirstNametextBox.Size = new Size(147, 62);
            ProfProfileFirstNametextBox.TabIndex = 17;
            // 
            // ProfProfileLastNameTextbox
            // 
            ProfProfileLastNameTextbox.Location = new Point(43, 376);
            ProfProfileLastNameTextbox.Multiline = true;
            ProfProfileLastNameTextbox.Name = "ProfProfileLastNameTextbox";
            ProfProfileLastNameTextbox.Size = new Size(147, 62);
            ProfProfileLastNameTextbox.TabIndex = 18;
            // 
            // ProfileButton
            // 
            ProfileButton.BackColor = Color.Pink;
            ProfileButton.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfileButton.Location = new Point(246, 302);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(130, 87);
            ProfileButton.TabIndex = 19;
            ProfileButton.Text = "Apply ";
            ProfileButton.UseVisualStyleBackColor = false;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // ProfileFirstNameLabel
            // 
            ProfileFirstNameLabel.AutoSize = true;
            ProfileFirstNameLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfileFirstNameLabel.Location = new Point(34, 227);
            ProfileFirstNameLabel.Name = "ProfileFirstNameLabel";
            ProfileFirstNameLabel.Size = new Size(156, 29);
            ProfileFirstNameLabel.TabIndex = 20;
            ProfileFirstNameLabel.Text = "First Name";
            // 
            // ProfileLastNameLabel
            // 
            ProfileLastNameLabel.AutoSize = true;
            ProfileLastNameLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfileLastNameLabel.Location = new Point(43, 344);
            ProfileLastNameLabel.Name = "ProfileLastNameLabel";
            ProfileLastNameLabel.Size = new Size(146, 29);
            ProfileLastNameLabel.TabIndex = 21;
            ProfileLastNameLabel.Text = "Last Name";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProfileLastNameLabel);
            Controls.Add(ProfileFirstNameLabel);
            Controls.Add(ProfileButton);
            Controls.Add(ProfProfileLastNameTextbox);
            Controls.Add(ProfProfileFirstNametextBox);
            Controls.Add(ProfilePictureButton);
            Controls.Add(ProfProfilePicture);
            Controls.Add(ProfProfileTextBox);
            Name = "Form9";
            Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)ProfProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProfProfileTextBox;
        private PictureBox ProfProfilePicture;
        private Button ProfilePictureButton;
        private TextBox ProfProfileFirstNametextBox;
        private TextBox ProfProfileLastNameTextbox;
        private Button ProfileButton;
        private Label ProfileFirstNameLabel;
        private Label ProfileLastNameLabel;
    }
}