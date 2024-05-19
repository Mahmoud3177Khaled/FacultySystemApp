namespace FacultySystemApp.admin.Courses
{
    partial class ShowAllCourses
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
            BackButton = new Button();
            label1 = new Label();
            Courses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Courses).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(33, 25);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 73;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(402, 24);
            label1.Name = "label1";
            label1.Size = new Size(185, 46);
            label1.TabIndex = 72;
            label1.Text = "All Courses";
            // 
            // Courses
            // 
            Courses.AllowUserToAddRows = false;
            Courses.AllowUserToDeleteRows = false;
            Courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Courses.Location = new Point(12, 91);
            Courses.Name = "Courses";
            Courses.ReadOnly = true;
            Courses.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Courses.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            Courses.RowTemplate.DefaultCellStyle.Format = "N3";
            Courses.RowTemplate.DefaultCellStyle.NullValue = null;
            Courses.Size = new Size(983, 509);
            Courses.TabIndex = 71;
            // 
            // ShowAllCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1004, 612);
            Controls.Add(BackButton);
            Controls.Add(label1);
            Controls.Add(Courses);
            ForeColor = Color.White;
            Name = "ShowAllCourses";
            Text = "ShowAllCourses";
            FormClosed += ShowAllCourses_FormClosed;
            Load += ShowAllCourses_Load;
            ((System.ComponentModel.ISupportInitialize)Courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label label1;
        private DataGridView Courses;
    }
}