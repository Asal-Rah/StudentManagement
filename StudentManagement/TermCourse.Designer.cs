namespace StudentManagement
{
    partial class TermCourse
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
            TermCourseListGrid = new DataGridView();
            TermCourseIdTextBox = new TextBox();
            TermCodeCoursetextBox = new TextBox();
            CourseIdLabel = new Label();
            label1 = new Label();
            TermCourseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TermCourseListGrid).BeginInit();
            SuspendLayout();
            // 
            // TermCourseListGrid
            // 
            TermCourseListGrid.BackgroundColor = Color.MintCream;
            TermCourseListGrid.BorderStyle = BorderStyle.Fixed3D;
            TermCourseListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TermCourseListGrid.Location = new Point(12, 33);
            TermCourseListGrid.Name = "TermCourseListGrid";
            TermCourseListGrid.RowHeadersWidth = 51;
            TermCourseListGrid.Size = new Size(582, 379);
            TermCourseListGrid.TabIndex = 2;
            // 
            // TermCourseIdTextBox
            // 
            TermCourseIdTextBox.Location = new Point(612, 79);
            TermCourseIdTextBox.Multiline = true;
            TermCourseIdTextBox.Name = "TermCourseIdTextBox";
            TermCourseIdTextBox.Size = new Size(166, 69);
            TermCourseIdTextBox.TabIndex = 3;
            // 
            // TermCodeCoursetextBox
            // 
            TermCodeCoursetextBox.Location = new Point(612, 221);
            TermCodeCoursetextBox.Multiline = true;
            TermCodeCoursetextBox.Name = "TermCodeCoursetextBox";
            TermCodeCoursetextBox.Size = new Size(166, 69);
            TermCodeCoursetextBox.TabIndex = 4;
            // 
            // CourseIdLabel
            // 
            CourseIdLabel.AutoSize = true;
            CourseIdLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            CourseIdLabel.Location = new Point(631, 33);
            CourseIdLabel.Name = "CourseIdLabel";
            CourseIdLabel.Size = new Size(126, 29);
            CourseIdLabel.TabIndex = 23;
            CourseIdLabel.Text = "Course Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 13.8F);
            label1.Location = new Point(631, 175);
            label1.Name = "label1";
            label1.Size = new Size(142, 29);
            label1.TabIndex = 24;
            label1.Text = "Term Code";
            // 
            // TermCourseButton
            // 
            TermCourseButton.BackColor = Color.Pink;
            TermCourseButton.Font = new Font("Lucida Calligraphy", 13.8F);
            TermCourseButton.Location = new Point(612, 326);
            TermCourseButton.Name = "TermCourseButton";
            TermCourseButton.Size = new Size(166, 59);
            TermCourseButton.TabIndex = 25;
            TermCourseButton.Text = "Add";
            TermCourseButton.UseVisualStyleBackColor = false;
            TermCourseButton.Click += TermCourseButton_Click;
            // 
            // TermCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TermCourseButton);
            Controls.Add(label1);
            Controls.Add(CourseIdLabel);
            Controls.Add(TermCodeCoursetextBox);
            Controls.Add(TermCourseIdTextBox);
            Controls.Add(TermCourseListGrid);
            Name = "TermCourse";
            Text = "TermCourse";
            ((System.ComponentModel.ISupportInitialize)TermCourseListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TermCourseListGrid;
        private TextBox TermCourseIdTextBox;
        private TextBox TermCodeCoursetextBox;
        private Label CourseIdLabel;
        private Label label1;
        private Button TermCourseButton;
    }
}