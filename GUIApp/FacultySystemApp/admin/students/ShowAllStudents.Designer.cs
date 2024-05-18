namespace FacultySystemApp.admin.students
{
    partial class ShowAllStudents
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            GraduationYear = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            Major = new ComboBox();
            label3 = new Label();
            Course = new ComboBox();
            label4 = new Label();
            ShowButton = new Button();
            GPA = new NumericUpDown();
            Students = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Students).BeginInit();
            SuspendLayout();
            // 
            // GraduationYear
            // 
            GraduationYear.BackColor = Color.Black;
            GraduationYear.DropDownStyle = ComboBoxStyle.DropDownList;
            GraduationYear.Font = new Font("Segoe UI", 15F);
            GraduationYear.ForeColor = Color.White;
            GraduationYear.FormattingEnabled = true;
            GraduationYear.Location = new Point(78, 92);
            GraduationYear.Name = "GraduationYear";
            GraduationYear.Size = new Size(164, 36);
            GraduationYear.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(84, 39);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 1;
            label1.Text = "Graduation Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(363, 39);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 3;
            label2.Text = "Major";
            // 
            // Major
            // 
            Major.BackColor = Color.Black;
            Major.DropDownStyle = ComboBoxStyle.DropDownList;
            Major.Font = new Font("Segoe UI", 15F);
            Major.ForeColor = Color.White;
            Major.FormattingEnabled = true;
            Major.Location = new Point(313, 92);
            Major.Name = "Major";
            Major.Size = new Size(164, 36);
            Major.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(594, 39);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 5;
            label3.Text = "Course";
            // 
            // Course
            // 
            Course.BackColor = Color.Black;
            Course.DropDownStyle = ComboBoxStyle.DropDownList;
            Course.Font = new Font("Segoe UI", 15F);
            Course.ForeColor = Color.White;
            Course.FormattingEnabled = true;
            Course.Location = new Point(548, 92);
            Course.Name = "Course";
            Course.Size = new Size(164, 36);
            Course.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(840, 39);
            label4.Name = "label4";
            label4.Size = new Size(49, 28);
            label4.TabIndex = 7;
            label4.Text = "GPA";
            // 
            // ShowButton
            // 
            ShowButton.Font = new Font("Segoe UI", 20F);
            ShowButton.ForeColor = Color.Black;
            ShowButton.Location = new Point(451, 163);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(142, 46);
            ShowButton.TabIndex = 0;
            ShowButton.Text = "Show";
            ShowButton.UseVisualStyleBackColor = true;
            ShowButton.Click += ShowButton_Click;
            // 
            // GPA
            // 
            GPA.DecimalPlaces = 3;
            GPA.Font = new Font("Segoe UI", 15F);
            GPA.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            GPA.Location = new Point(791, 92);
            GPA.Name = "GPA";
            GPA.Size = new Size(164, 34);
            GPA.TabIndex = 9;
            // 
            // Students
            // 
            Students.AllowUserToAddRows = false;
            Students.AllowUserToDeleteRows = false;
            Students.BackgroundColor = Color.Black;
            Students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Students.DefaultCellStyle = dataGridViewCellStyle1;
            Students.Location = new Point(12, 215);
            Students.Name = "Students";
            Students.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            Students.RowsDefaultCellStyle = dataGridViewCellStyle2;
            Students.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Students.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            Students.Size = new Size(1014, 387);
            Students.TabIndex = 10;
            // 
            // ShowAllStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1038, 614);
            Controls.Add(Students);
            Controls.Add(GPA);
            Controls.Add(ShowButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Course);
            Controls.Add(label2);
            Controls.Add(Major);
            Controls.Add(label1);
            Controls.Add(GraduationYear);
            ForeColor = Color.White;
            Name = "ShowAllStudents";
            Text = "ShowAllStudents";
            FormClosed += ShowAllStudents_close;
            Load += ShowAllStudents_Load;
            ((System.ComponentModel.ISupportInitialize)GPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)Students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox GraduationYear;
        private Label label1;
        private Label label2;
        private ComboBox Major;
        private Label label3;
        private ComboBox Course;
        private Label label4;
        private Button ShowButton;
        private NumericUpDown GPA;
        private DataGridView Students;
    }
}