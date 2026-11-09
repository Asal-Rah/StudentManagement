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
            nationalCodeCourseTextBox = new TextBox();
            CourseIdLabel = new Label();
            nationalcodecourselabel = new Label();
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
            CourseTextBox.Location = new Point(622, 94);
            CourseTextBox.Multiline = true;
            CourseTextBox.Name = "CourseTextBox";
            CourseTextBox.Size = new Size(166, 69);
            CourseTextBox.TabIndex = 2;
            // 
            // EnrollButton
            // 
            EnrollButton.BackColor = Color.Pink;
            EnrollButton.Font = new Font("Lucida Calligraphy", 13.8F);
            EnrollButton.Location = new Point(622, 342);
            EnrollButton.Name = "EnrollButton";
            EnrollButton.Size = new Size(166, 59);
            EnrollButton.TabIndex = 20;
            EnrollButton.Text = "Enroll";
            EnrollButton.UseVisualStyleBackColor = false;
            EnrollButton.Click += EnrollButton_Click;
            // 
            // nationalCodeCourseTextBox
            // 
            nationalCodeCourseTextBox.Location = new Point(622, 225);
            nationalCodeCourseTextBox.Multiline = true;
            nationalCodeCourseTextBox.Name = "nationalCodeCourseTextBox";
            nationalCodeCourseTextBox.Size = new Size(166, 69);
            nationalCodeCourseTextBox.TabIndex = 21;
            // 
            // CourseIdLabel
            // 
            CourseIdLabel.AutoSize = true;
            CourseIdLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            CourseIdLabel.Location = new Point(641, 50);
            CourseIdLabel.Name = "CourseIdLabel";
            CourseIdLabel.Size = new Size(126, 29);
            CourseIdLabel.TabIndex = 22;
            CourseIdLabel.Text = "Course Id";
            // 
            // nationalcodecourselabel
            // 
            nationalcodecourselabel.AutoSize = true;
            nationalcodecourselabel.Font = new Font("Lucida Calligraphy", 13.8F);
            nationalcodecourselabel.Location = new Point(622, 183);
            nationalcodecourselabel.Name = "nationalcodecourselabel";
            nationalcodecourselabel.Size = new Size(171, 29);
            nationalcodecourselabel.TabIndex = 23;
            nationalcodecourselabel.Text = "nationalCode";
            // 
            // CoursesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nationalcodecourselabel);
            Controls.Add(CourseIdLabel);
            Controls.Add(nationalCodeCourseTextBox);
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
        private TextBox nationalCodeCourseTextBox;
        private Label CourseIdLabel;
        private Label nationalcodecourselabel;
    }
}