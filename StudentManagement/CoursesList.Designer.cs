namespace StudentManagement
{
    partial class CoursesList
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
            CourseListGrid = new DataGridView();
            CourseTextBox = new TextBox();
            EnrollButton = new Button();
            CourseIdLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CourseListGrid).BeginInit();
            SuspendLayout();
            // 
            // CourseListGrid
            // 
            CourseListGrid.BackgroundColor = Color.MintCream;
            CourseListGrid.BorderStyle = BorderStyle.Fixed3D;
            CourseListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseListGrid.Location = new Point(12, 32);
            CourseListGrid.Name = "CourseListGrid";
            CourseListGrid.RowHeadersWidth = 51;
            CourseListGrid.Size = new Size(582, 379);
            CourseListGrid.TabIndex = 1;
            // 
            // CourseTextBox
            // 
            CourseTextBox.Location = new Point(622, 141);
            CourseTextBox.Multiline = true;
            CourseTextBox.Name = "CourseTextBox";
            CourseTextBox.Size = new Size(166, 69);
            CourseTextBox.TabIndex = 2;
            // 
            // EnrollButton
            // 
            EnrollButton.BackColor = Color.Pink;
            EnrollButton.Font = new Font("Lucida Calligraphy", 13.8F);
            EnrollButton.Location = new Point(622, 249);
            EnrollButton.Name = "EnrollButton";
            EnrollButton.Size = new Size(166, 59);
            EnrollButton.TabIndex = 20;
            EnrollButton.Text = "Enroll";
            EnrollButton.UseVisualStyleBackColor = false;
            EnrollButton.Click += EnrollButton_Click;
            // 
            // CourseIdLabel
            // 
            CourseIdLabel.AutoSize = true;
            CourseIdLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            CourseIdLabel.Location = new Point(639, 90);
            CourseIdLabel.Name = "CourseIdLabel";
            CourseIdLabel.Size = new Size(126, 29);
            CourseIdLabel.TabIndex = 22;
            CourseIdLabel.Text = "Course Id";
            // 
            // CoursesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CourseIdLabel);
            Controls.Add(EnrollButton);
            Controls.Add(CourseTextBox);
            Controls.Add(CourseListGrid);
            Name = "CoursesList";
            Text = "CoursesList";
            ((System.ComponentModel.ISupportInitialize)CourseListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CourseListGrid;
        private TextBox CourseTextBox;
        private Button EnrollButton;
        private Label CourseIdLabel;
    }
}