namespace StudentManagement
{
    partial class Form3
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
            AgetextBox = new TextBox();
            PhoneNumbertextBox = new TextBox();
            FisrtNametextBox = new TextBox();
            NationalCodetextBox = new TextBox();
            LastNametextBox = new TextBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            AgeLabel = new Label();
            NationalCodeLabel = new Label();
            PhoneNumberLabel = new Label();
            RegisterButton = new Button();
            SuspendLayout();
            // 
            // AgetextBox
            // 
            AgetextBox.Location = new Point(580, 42);
            AgetextBox.Multiline = true;
            AgetextBox.Name = "AgetextBox";
            AgetextBox.Size = new Size(208, 55);
            AgetextBox.TabIndex = 0;
            // 
            // PhoneNumbertextBox
            // 
            PhoneNumbertextBox.Location = new Point(580, 244);
            PhoneNumbertextBox.Multiline = true;
            PhoneNumbertextBox.Name = "PhoneNumbertextBox";
            PhoneNumbertextBox.Size = new Size(208, 55);
            PhoneNumbertextBox.TabIndex = 1;
            // 
            // FisrtNametextBox
            // 
            FisrtNametextBox.Location = new Point(158, 42);
            FisrtNametextBox.Multiline = true;
            FisrtNametextBox.Name = "FisrtNametextBox";
            FisrtNametextBox.Size = new Size(208, 55);
            FisrtNametextBox.TabIndex = 2;
            // 
            // NationalCodetextBox
            // 
            NationalCodetextBox.Location = new Point(580, 147);
            NationalCodetextBox.Multiline = true;
            NationalCodetextBox.Name = "NationalCodetextBox";
            NationalCodetextBox.Size = new Size(208, 55);
            NationalCodetextBox.TabIndex = 3;
            // 
            // LastNametextBox
            // 
            LastNametextBox.Location = new Point(158, 147);
            LastNametextBox.Multiline = true;
            LastNametextBox.Name = "LastNametextBox";
            LastNametextBox.Size = new Size(208, 55);
            LastNametextBox.TabIndex = 4;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            FirstNameLabel.Location = new Point(0, 54);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(162, 29);
            FirstNameLabel.TabIndex = 5;
            FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            LastNameLabel.Location = new Point(0, 164);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(152, 29);
            LastNameLabel.TabIndex = 6;
            LastNameLabel.Text = "Last Name:";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            AgeLabel.Location = new Point(507, 54);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(67, 29);
            AgeLabel.TabIndex = 7;
            AgeLabel.Text = "Age:";
            // 
            // NationalCodeLabel
            // 
            NationalCodeLabel.AutoSize = true;
            NationalCodeLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            NationalCodeLabel.Location = new Point(382, 164);
            NationalCodeLabel.Name = "NationalCodeLabel";
            NationalCodeLabel.Size = new Size(193, 29);
            NationalCodeLabel.TabIndex = 8;
            NationalCodeLabel.Text = "National Code:";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            PhoneNumberLabel.Location = new Point(370, 256);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(204, 29);
            PhoneNumberLabel.TabIndex = 9;
            PhoneNumberLabel.Text = "Phone Number:";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Pink;
            RegisterButton.Font = new Font("Lucida Calligraphy", 13.8F);
            RegisterButton.Location = new Point(95, 292);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(224, 74);
            RegisterButton.TabIndex = 10;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegisterButton);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(NationalCodeLabel);
            Controls.Add(AgeLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(LastNametextBox);
            Controls.Add(NationalCodetextBox);
            Controls.Add(FisrtNametextBox);
            Controls.Add(PhoneNumbertextBox);
            Controls.Add(AgetextBox);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AgetextBox;
        private TextBox PhoneNumbertextBox;
        private TextBox FisrtNametextBox;
        private TextBox NationalCodetextBox;
        private TextBox LastNametextBox;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label AgeLabel;
        private Label NationalCodeLabel;
        private Label PhoneNumberLabel;
        private Button RegisterButton;
    }
}