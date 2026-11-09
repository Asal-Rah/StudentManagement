namespace StudentManagement
{
    partial class MyCourse
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
            MyCourseListGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)MyCourseListGrid).BeginInit();
            SuspendLayout();
            // 
            // MyCourseListGrid
            // 
            MyCourseListGrid.BackgroundColor = Color.MintCream;
            MyCourseListGrid.BorderStyle = BorderStyle.Fixed3D;
            MyCourseListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MyCourseListGrid.Location = new Point(104, 39);
            MyCourseListGrid.Name = "MyCourseListGrid";
            MyCourseListGrid.RowHeadersWidth = 51;
            MyCourseListGrid.Size = new Size(582, 379);
            MyCourseListGrid.TabIndex = 2;
            MyCourseListGrid.CellContentClick += CourseListGrid_CellContentClick;
            // 
            // MyCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MyCourseListGrid);
            Name = "MyCourse";
            Text = "MyCourse";
            ((System.ComponentModel.ISupportInitialize)MyCourseListGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView MyCourseListGrid;
    }
}