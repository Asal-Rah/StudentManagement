namespace StudentManagement
{
    partial class Form7
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
            ProfessorFirstName = new Label();
            ProfessorLastName = new Label();
            ProfessorAge = new Label();
            ProfessorPhoneNumber = new Label();
            label1 = new Label();
            label2 = new Label();
            ProfPhonetextBox = new TextBox();
            ProfNarionalCodetextBox = new TextBox();
            ProfCardtextBox = new TextBox();
            ProfNametextBox = new TextBox();
            ProfLastNametextBox = new TextBox();
            ProfAgetextBox = new TextBox();
            RegisterButton = new Button();
            SuspendLayout();
            // 
            // ProfessorFirstName
            // 
            ProfessorFirstName.AutoSize = true;
            ProfessorFirstName.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfessorFirstName.Location = new Point(12, 54);
            ProfessorFirstName.Name = "ProfessorFirstName";
            ProfessorFirstName.Size = new Size(162, 29);
            ProfessorFirstName.TabIndex = 6;
            ProfessorFirstName.Text = "First Name:";
            // 
            // ProfessorLastName
            // 
            ProfessorLastName.AutoSize = true;
            ProfessorLastName.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfessorLastName.Location = new Point(23, 150);
            ProfessorLastName.Name = "ProfessorLastName";
            ProfessorLastName.Size = new Size(152, 29);
            ProfessorLastName.TabIndex = 7;
            ProfessorLastName.Text = "Last Name:";
            // 
            // ProfessorAge
            // 
            ProfessorAge.AutoSize = true;
            ProfessorAge.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfessorAge.Location = new Point(107, 230);
            ProfessorAge.Name = "ProfessorAge";
            ProfessorAge.Size = new Size(67, 29);
            ProfessorAge.TabIndex = 8;
            ProfessorAge.Text = "Age:";
            // 
            // ProfessorPhoneNumber
            // 
            ProfessorPhoneNumber.AutoSize = true;
            ProfessorPhoneNumber.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfessorPhoneNumber.Location = new Point(408, 54);
            ProfessorPhoneNumber.Name = "ProfessorPhoneNumber";
            ProfessorPhoneNumber.Size = new Size(204, 29);
            ProfessorPhoneNumber.TabIndex = 9;
            ProfessorPhoneNumber.Text = "Phone Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 13.8F);
            label1.Location = new Point(419, 150);
            label1.Name = "label1";
            label1.Size = new Size(193, 29);
            label1.TabIndex = 10;
            label1.Text = "National Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 13.8F);
            label2.Location = new Point(534, 230);
            label2.Name = "label2";
            label2.Size = new Size(78, 29);
            label2.TabIndex = 11;
            label2.Text = "Card:";
            // 
            // ProfPhonetextBox
            // 
            ProfPhonetextBox.Location = new Point(618, 45);
            ProfPhonetextBox.Multiline = true;
            ProfPhonetextBox.Name = "ProfPhonetextBox";
            ProfPhonetextBox.Size = new Size(157, 47);
            ProfPhonetextBox.TabIndex = 12;
            // 
            // ProfNarionalCodetextBox
            // 
            ProfNarionalCodetextBox.Location = new Point(618, 132);
            ProfNarionalCodetextBox.Multiline = true;
            ProfNarionalCodetextBox.Name = "ProfNarionalCodetextBox";
            ProfNarionalCodetextBox.Size = new Size(157, 47);
            ProfNarionalCodetextBox.TabIndex = 13;
            // 
            // ProfCardtextBox
            // 
            ProfCardtextBox.Location = new Point(618, 212);
            ProfCardtextBox.Multiline = true;
            ProfCardtextBox.Name = "ProfCardtextBox";
            ProfCardtextBox.Size = new Size(157, 47);
            ProfCardtextBox.TabIndex = 14;
            // 
            // ProfNametextBox
            // 
            ProfNametextBox.Location = new Point(197, 45);
            ProfNametextBox.Multiline = true;
            ProfNametextBox.Name = "ProfNametextBox";
            ProfNametextBox.Size = new Size(157, 47);
            ProfNametextBox.TabIndex = 15;
            // 
            // ProfLastNametextBox
            // 
            ProfLastNametextBox.Location = new Point(197, 135);
            ProfLastNametextBox.Multiline = true;
            ProfLastNametextBox.Name = "ProfLastNametextBox";
            ProfLastNametextBox.Size = new Size(157, 47);
            ProfLastNametextBox.TabIndex = 16;
            // 
            // ProfAgetextBox
            // 
            ProfAgetextBox.Location = new Point(197, 212);
            ProfAgetextBox.Multiline = true;
            ProfAgetextBox.Name = "ProfAgetextBox";
            ProfAgetextBox.Size = new Size(157, 47);
            ProfAgetextBox.TabIndex = 17;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Pink;
            RegisterButton.Font = new Font("Lucida Calligraphy", 13.8F);
            RegisterButton.Location = new Point(262, 323);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(224, 74);
            RegisterButton.TabIndex = 18;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegisterButton);
            Controls.Add(ProfAgetextBox);
            Controls.Add(ProfLastNametextBox);
            Controls.Add(ProfNametextBox);
            Controls.Add(ProfCardtextBox);
            Controls.Add(ProfNarionalCodetextBox);
            Controls.Add(ProfPhonetextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProfessorPhoneNumber);
            Controls.Add(ProfessorAge);
            Controls.Add(ProfessorLastName);
            Controls.Add(ProfessorFirstName);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProfessorFirstName;
        private Label ProfessorLastName;
        private Label ProfessorAge;
        private Label ProfessorPhoneNumber;
        private Label label1;
        private Label label2;
        private TextBox ProfPhonetextBox;
        private TextBox ProfNarionalCodetextBox;
        private TextBox ProfCardtextBox;
        private TextBox ProfNametextBox;
        private TextBox ProfLastNametextBox;
        private TextBox ProfAgetextBox;
        private Button RegisterButton;
    }
}