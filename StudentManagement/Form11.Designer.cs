namespace StudentManagement
{
    partial class Form11
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
            SecondPageLabel = new Label();
            HaveButton = new Button();
            DontHaveButton = new Button();
            SuspendLayout();
            // 
            // SecondPageLabel
            // 
            SecondPageLabel.AutoSize = true;
            SecondPageLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            SecondPageLabel.Location = new Point(208, 102);
            SecondPageLabel.Name = "SecondPageLabel";
            SecondPageLabel.Size = new Size(322, 29);
            SecondPageLabel.TabIndex = 15;
            SecondPageLabel.Text = "Do you have an account?";
            // 
            // HaveButton
            // 
            HaveButton.BackColor = Color.Pink;
            HaveButton.Font = new Font("Lucida Calligraphy", 13.8F);
            HaveButton.Location = new Point(151, 186);
            HaveButton.Name = "HaveButton";
            HaveButton.Size = new Size(168, 50);
            HaveButton.TabIndex = 16;
            HaveButton.Text = "Yes";
            HaveButton.UseVisualStyleBackColor = false;
            HaveButton.Click += HaveButton_Click;
            // 
            // DontHaveButton
            // 
            DontHaveButton.BackColor = Color.Pink;
            DontHaveButton.Font = new Font("Lucida Calligraphy", 13.8F);
            DontHaveButton.Location = new Point(401, 186);
            DontHaveButton.Name = "DontHaveButton";
            DontHaveButton.Size = new Size(168, 50);
            DontHaveButton.TabIndex = 17;
            DontHaveButton.Text = "No";
            DontHaveButton.UseVisualStyleBackColor = false;
            DontHaveButton.Click += DontHaveButton_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DontHaveButton);
            Controls.Add(HaveButton);
            Controls.Add(SecondPageLabel);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SecondPageLabel;
        private Button HaveButton;
        private Button DontHaveButton;
    }
}