namespace StudentManagement
{
    partial class Form10
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
            WelcomeMessageLabel = new Label();
            WelcomePageButton = new Button();
            WelcomeNoButton = new Button();
            SuspendLayout();
            // 
            // WelcomeMessageLabel
            // 
            WelcomeMessageLabel.AutoSize = true;
            WelcomeMessageLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            WelcomeMessageLabel.Location = new Point(115, 75);
            WelcomeMessageLabel.Name = "WelcomeMessageLabel";
            WelcomeMessageLabel.Size = new Size(580, 29);
            WelcomeMessageLabel.TabIndex = 14;
            WelcomeMessageLabel.Text = "Welcome to the X institute! Are you a student?";
            // 
            // WelcomePageButton
            // 
            WelcomePageButton.BackColor = Color.Pink;
            WelcomePageButton.Font = new Font("Lucida Calligraphy", 13.8F);
            WelcomePageButton.Location = new Point(296, 153);
            WelcomePageButton.Name = "WelcomePageButton";
            WelcomePageButton.Size = new Size(168, 50);
            WelcomePageButton.TabIndex = 15;
            WelcomePageButton.Text = "Yes";
            WelcomePageButton.UseVisualStyleBackColor = false;
            WelcomePageButton.Click += WelcomePageButton_Click;
            // 
            // WelcomeNoButton
            // 
            WelcomeNoButton.BackColor = Color.Pink;
            WelcomeNoButton.Font = new Font("Lucida Calligraphy", 13.8F);
            WelcomeNoButton.Location = new Point(296, 239);
            WelcomeNoButton.Name = "WelcomeNoButton";
            WelcomeNoButton.Size = new Size(168, 50);
            WelcomeNoButton.TabIndex = 16;
            WelcomeNoButton.Text = "No";
            WelcomeNoButton.UseVisualStyleBackColor = false;
            WelcomeNoButton.Click += WelcomeNoButton_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WelcomeNoButton);
            Controls.Add(WelcomePageButton);
            Controls.Add(WelcomeMessageLabel);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeMessageLabel;
        private Button WelcomePageButton;
        private Button WelcomeNoButton;
    }
}