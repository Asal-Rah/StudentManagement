namespace StudentManagement
{
    partial class Form4
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
            StudentListGrid = new DataGridView();
            NameFilter = new TextBox();
            LastNameFilter = new TextBox();
            NationalCodeFilter = new TextBox();
            FilterButton = new Button();
            FirstNameFilterLabel = new Label();
            LastNameFilterLabel = new Label();
            NationalCodeFilterLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)StudentListGrid).BeginInit();
            SuspendLayout();
            // 
            // StudentListGrid
            // 
            StudentListGrid.BackgroundColor = Color.MintCream;
            StudentListGrid.BorderStyle = BorderStyle.Fixed3D;
            StudentListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentListGrid.Location = new Point(197, 34);
            StudentListGrid.Name = "StudentListGrid";
            StudentListGrid.RowHeadersWidth = 51;
            StudentListGrid.Size = new Size(582, 379);
            StudentListGrid.TabIndex = 0;
            // 
            // NameFilter
            // 
            NameFilter.Location = new Point(12, 66);
            NameFilter.Multiline = true;
            NameFilter.Name = "NameFilter";
            NameFilter.Size = new Size(168, 46);
            NameFilter.TabIndex = 1;
            // 
            // LastNameFilter
            // 
            LastNameFilter.Location = new Point(12, 171);
            LastNameFilter.Multiline = true;
            LastNameFilter.Name = "LastNameFilter";
            LastNameFilter.Size = new Size(168, 46);
            LastNameFilter.TabIndex = 2;
            // 
            // NationalCodeFilter
            // 
            NationalCodeFilter.Location = new Point(12, 275);
            NationalCodeFilter.Multiline = true;
            NationalCodeFilter.Name = "NationalCodeFilter";
            NationalCodeFilter.Size = new Size(168, 46);
            NationalCodeFilter.TabIndex = 3;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.Pink;
            FilterButton.Font = new Font("Lucida Calligraphy", 13.8F);
            FilterButton.Location = new Point(12, 354);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(168, 50);
            FilterButton.TabIndex = 11;
            FilterButton.Text = "Apply ";
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // FirstNameFilterLabel
            // 
            FirstNameFilterLabel.AutoSize = true;
            FirstNameFilterLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            FirstNameFilterLabel.Location = new Point(12, 34);
            FirstNameFilterLabel.Name = "FirstNameFilterLabel";
            FirstNameFilterLabel.Size = new Size(156, 29);
            FirstNameFilterLabel.TabIndex = 12;
            FirstNameFilterLabel.Text = "First Name";
            // 
            // LastNameFilterLabel
            // 
            LastNameFilterLabel.AutoSize = true;
            LastNameFilterLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            LastNameFilterLabel.Location = new Point(12, 130);
            LastNameFilterLabel.Name = "LastNameFilterLabel";
            LastNameFilterLabel.Size = new Size(146, 29);
            LastNameFilterLabel.TabIndex = 13;
            LastNameFilterLabel.Text = "Last Name";
            // 
            // NationalCodeFilterLabel
            // 
            NationalCodeFilterLabel.AutoSize = true;
            NationalCodeFilterLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            NationalCodeFilterLabel.Location = new Point(4, 233);
            NationalCodeFilterLabel.Name = "NationalCodeFilterLabel";
            NationalCodeFilterLabel.Size = new Size(187, 29);
            NationalCodeFilterLabel.TabIndex = 14;
            NationalCodeFilterLabel.Text = "National Code";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NationalCodeFilterLabel);
            Controls.Add(LastNameFilterLabel);
            Controls.Add(FirstNameFilterLabel);
            Controls.Add(FilterButton);
            Controls.Add(NationalCodeFilter);
            Controls.Add(LastNameFilter);
            Controls.Add(NameFilter);
            Controls.Add(StudentListGrid);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)StudentListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentListGrid;
        private TextBox NameFilter;
        private TextBox LastNameFilter;
        private TextBox NationalCodeFilter;
        private Button FilterButton;
        private Label FirstNameFilterLabel;
        private Label LastNameFilterLabel;
        private Label NationalCodeFilterLabel;
    }
}