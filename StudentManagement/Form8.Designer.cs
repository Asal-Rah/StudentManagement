namespace StudentManagement
{
    partial class Form8
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
            ProfListGrid = new DataGridView();
            ProfFirstNameFilter = new TextBox();
            ProfLastNameFilter = new TextBox();
            ProfFirstNameFilterLabel = new Label();
            ProfLastNameFilterLabel = new Label();
            ProfFilterButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProfListGrid).BeginInit();
            SuspendLayout();
            // 
            // ProfListGrid
            // 
            ProfListGrid.BackgroundColor = Color.MintCream;
            ProfListGrid.BorderStyle = BorderStyle.Fixed3D;
            ProfListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProfListGrid.Location = new Point(206, 33);
            ProfListGrid.Name = "ProfListGrid";
            ProfListGrid.RowHeadersWidth = 51;
            ProfListGrid.Size = new Size(582, 379);
            ProfListGrid.TabIndex = 1;
            ProfListGrid.CellContentClick += StudentListGrid_CellContentClick;
            // 
            // ProfFirstNameFilter
            // 
            ProfFirstNameFilter.Location = new Point(12, 101);
            ProfFirstNameFilter.Multiline = true;
            ProfFirstNameFilter.Name = "ProfFirstNameFilter";
            ProfFirstNameFilter.Size = new Size(168, 46);
            ProfFirstNameFilter.TabIndex = 3;
            // 
            // ProfLastNameFilter
            // 
            ProfLastNameFilter.Location = new Point(12, 226);
            ProfLastNameFilter.Multiline = true;
            ProfLastNameFilter.Name = "ProfLastNameFilter";
            ProfLastNameFilter.Size = new Size(168, 46);
            ProfLastNameFilter.TabIndex = 4;
            // 
            // ProfFirstNameFilterLabel
            // 
            ProfFirstNameFilterLabel.AutoSize = true;
            ProfFirstNameFilterLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfFirstNameFilterLabel.Location = new Point(12, 51);
            ProfFirstNameFilterLabel.Name = "ProfFirstNameFilterLabel";
            ProfFirstNameFilterLabel.Size = new Size(156, 29);
            ProfFirstNameFilterLabel.TabIndex = 13;
            ProfFirstNameFilterLabel.Text = "First Name";
            // 
            // ProfLastNameFilterLabel
            // 
            ProfLastNameFilterLabel.AutoSize = true;
            ProfLastNameFilterLabel.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfLastNameFilterLabel.Location = new Point(22, 177);
            ProfLastNameFilterLabel.Name = "ProfLastNameFilterLabel";
            ProfLastNameFilterLabel.Size = new Size(146, 29);
            ProfLastNameFilterLabel.TabIndex = 14;
            ProfLastNameFilterLabel.Text = "Last Name";
            // 
            // ProfFilterButton
            // 
            ProfFilterButton.BackColor = Color.Pink;
            ProfFilterButton.Font = new Font("Lucida Calligraphy", 13.8F);
            ProfFilterButton.Location = new Point(12, 328);
            ProfFilterButton.Name = "ProfFilterButton";
            ProfFilterButton.Size = new Size(168, 50);
            ProfFilterButton.TabIndex = 15;
            ProfFilterButton.Text = "Apply ";
            ProfFilterButton.UseVisualStyleBackColor = false;
            ProfFilterButton.Click += ProfFilterButton_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ProfFilterButton);
            Controls.Add(ProfLastNameFilterLabel);
            Controls.Add(ProfFirstNameFilterLabel);
            Controls.Add(ProfLastNameFilter);
            Controls.Add(ProfFirstNameFilter);
            Controls.Add(ProfListGrid);
            Name = "Form8";
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)ProfListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProfListGrid;
        private TextBox ProfFirstNameFilter;
        private TextBox ProfLastNameFilter;
        private Label ProfFirstNameFilterLabel;
        private Label ProfLastNameFilterLabel;
        private Button ProfFilterButton;
    }
}