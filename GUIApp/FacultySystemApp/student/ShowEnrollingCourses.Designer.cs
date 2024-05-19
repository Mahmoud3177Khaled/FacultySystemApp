namespace FacultySystemApp.student
{
    partial class ShowEnrollingCourses
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
            label1 = new Label();
            BackButton = new Button();
            EnrollingCourses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)EnrollingCourses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(398, 26);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 0;
            label1.Text = "Enrolling Courses";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(47, 16);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 75;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // EnrollingCourses
            // 
            EnrollingCourses.AllowUserToAddRows = false;
            EnrollingCourses.AllowUserToDeleteRows = false;
            EnrollingCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EnrollingCourses.Location = new Point(12, 86);
            EnrollingCourses.Name = "EnrollingCourses";
            EnrollingCourses.ReadOnly = true;
            EnrollingCourses.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnrollingCourses.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            EnrollingCourses.RowTemplate.DefaultCellStyle.Format = "N3";
            EnrollingCourses.RowTemplate.DefaultCellStyle.NullValue = null;
            EnrollingCourses.Size = new Size(995, 509);
            EnrollingCourses.TabIndex = 74;
            // 
            // ShowEnrollingCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1019, 607);
            Controls.Add(BackButton);
            Controls.Add(EnrollingCourses);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "ShowEnrollingCourses";
            Text = "ShowEnrollingCourses";
            FormClosed += ShowEnrollingCourses_FormClosed;
            Load += ShowEnrollingCourses_Load;
            ((System.ComponentModel.ISupportInitialize)EnrollingCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BackButton;
        private DataGridView EnrollingCourses;
    }
}