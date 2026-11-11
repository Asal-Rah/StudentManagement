namespace StudentManagement
{
    partial class Term
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
            TermCodeTextbox = new TextBox();
            TermSeasontextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            CreateTermButton = new Button();
            TermStarttextBox = new TextBox();
            TermEndtextBox = new TextBox();
            SuspendLayout();
            // 
            // TermCodeTextbox
            // 
            TermCodeTextbox.Location = new Point(176, 88);
            TermCodeTextbox.Multiline = true;
            TermCodeTextbox.Name = "TermCodeTextbox";
            TermCodeTextbox.Size = new Size(197, 74);
            TermCodeTextbox.TabIndex = 14;
            // 
            // TermSeasontextBox
            // 
            TermSeasontextBox.Location = new Point(176, 212);
            TermSeasontextBox.Multiline = true;
            TermSeasontextBox.Name = "TermSeasontextBox";
            TermSeasontextBox.Size = new Size(197, 74);
            TermSeasontextBox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 13.8F);
            label2.Location = new Point(22, 109);
            label2.Name = "label2";
            label2.Size = new Size(148, 29);
            label2.TabIndex = 18;
            label2.Text = "Term Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 13.8F);
            label1.Location = new Point(-1, 230);
            label1.Name = "label1";
            label1.Size = new Size(171, 29);
            label1.TabIndex = 19;
            label1.Text = "Term Season:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 13.8F);
            label3.Location = new Point(433, 230);
            label3.Name = "label3";
            label3.Size = new Size(134, 29);
            label3.TabIndex = 20;
            label3.Text = "End Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 13.8F);
            label4.Location = new Point(420, 109);
            label4.Name = "label4";
            label4.Size = new Size(147, 29);
            label4.TabIndex = 21;
            label4.Text = "Start Date:";
            // 
            // CreateTermButton
            // 
            CreateTermButton.BackColor = Color.Pink;
            CreateTermButton.Font = new Font("Lucida Calligraphy", 13.8F);
            CreateTermButton.Location = new Point(286, 341);
            CreateTermButton.Name = "CreateTermButton";
            CreateTermButton.Size = new Size(224, 74);
            CreateTermButton.TabIndex = 22;
            CreateTermButton.Text = "Create Term";
            CreateTermButton.UseVisualStyleBackColor = false;
            CreateTermButton.Click += CreateTermButton_Click;
            // 
            // TermStarttextBox
            // 
            TermStarttextBox.Location = new Point(573, 88);
            TermStarttextBox.Multiline = true;
            TermStarttextBox.Name = "TermStarttextBox";
            TermStarttextBox.Size = new Size(197, 74);
            TermStarttextBox.TabIndex = 23;
            // 
            // TermEndtextBox
            // 
            TermEndtextBox.Location = new Point(573, 212);
            TermEndtextBox.Multiline = true;
            TermEndtextBox.Name = "TermEndtextBox";
            TermEndtextBox.Size = new Size(197, 74);
            TermEndtextBox.TabIndex = 24;
            // 
            // Term
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TermEndtextBox);
            Controls.Add(TermStarttextBox);
            Controls.Add(CreateTermButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(TermSeasontextBox);
            Controls.Add(TermCodeTextbox);
            Name = "Term";
            Text = "Termcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TermCodeTextbox;
        private TextBox TermSeasontextBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button CreateTermButton;
        private TextBox TermStarttextBox;
        private TextBox TermEndtextBox;
    }
}