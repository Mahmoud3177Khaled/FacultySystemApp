namespace FacultySystemApp.admin.Courses
{
    partial class ShowCourse
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BackButton = new Button();
            EditCourseButton = new Button();
            label5 = new Label();
            username = new TextBox();
            CourseIDLabel = new Label();
            RemoveCourseButton = new Button();
            EnrollStudentButton = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(383, 335);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(402, 43);
            textBox3.TabIndex = 90;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(383, 271);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(402, 43);
            textBox2.TabIndex = 89;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(383, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 43);
            textBox1.TabIndex = 88;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(142, 189);
            label4.Name = "label4";
            label4.Size = new Size(196, 54);
            label4.TabIndex = 87;
            label4.Text = "Course ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 30F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(91, 260);
            label3.Name = "label3";
            label3.Size = new Size(247, 54);
            label3.TabIndex = 86;
            label3.Text = "Credit Hours";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 30F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 325);
            label2.Name = "label2";
            label2.Size = new Size(286, 54);
            label2.TabIndex = 85;
            label2.Text = "Department ID";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(34, 17);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 84;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // EditCourseButton
            // 
            EditCourseButton.Font = new Font("Segoe UI", 20F);
            EditCourseButton.ForeColor = Color.Black;
            EditCourseButton.Location = new Point(124, 403);
            EditCourseButton.Name = "EditCourseButton";
            EditCourseButton.Size = new Size(90, 46);
            EditCourseButton.TabIndex = 83;
            EditCourseButton.Text = "Edit";
            EditCourseButton.UseVisualStyleBackColor = true;
            EditCourseButton.Click += EditCourseButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(76, 122);
            label5.Name = "label5";
            label5.Size = new Size(262, 54);
            label5.TabIndex = 82;
            label5.Text = "Course Name";
            // 
            // username
            // 
            username.Enabled = false;
            username.Font = new Font("Segoe UI", 20F);
            username.Location = new Point(383, 122);
            username.Name = "username";
            username.Size = new Size(402, 43);
            username.TabIndex = 81;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // CourseIDLabel
            // 
            CourseIDLabel.AutoSize = true;
            CourseIDLabel.Font = new Font("Segoe UI", 25F);
            CourseIDLabel.Location = new Point(271, 18);
            CourseIDLabel.Name = "CourseIDLabel";
            CourseIDLabel.Size = new Size(177, 46);
            CourseIDLabel.TabIndex = 80;
            CourseIDLabel.Text = "Course : id";
            // 
            // RemoveCourseButton
            // 
            RemoveCourseButton.Font = new Font("Segoe UI", 20F);
            RemoveCourseButton.ForeColor = Color.Black;
            RemoveCourseButton.Location = new Point(561, 403);
            RemoveCourseButton.Name = "RemoveCourseButton";
            RemoveCourseButton.Size = new Size(133, 46);
            RemoveCourseButton.TabIndex = 91;
            RemoveCourseButton.Text = "Remove";
            RemoveCourseButton.UseVisualStyleBackColor = true;
            // 
            // EnrollStudentButton
            // 
            EnrollStudentButton.Font = new Font("Segoe UI", 20F);
            EnrollStudentButton.ForeColor = Color.Black;
            EnrollStudentButton.Location = new Point(290, 403);
            EnrollStudentButton.Name = "EnrollStudentButton";
            EnrollStudentButton.Size = new Size(195, 46);
            EnrollStudentButton.TabIndex = 92;
            EnrollStudentButton.Text = "Enroll Student";
            EnrollStudentButton.UseVisualStyleBackColor = true;
            // 
            // ShowCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(818, 477);
            Controls.Add(EnrollStudentButton);
            Controls.Add(RemoveCourseButton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BackButton);
            Controls.Add(EditCourseButton);
            Controls.Add(label5);
            Controls.Add(username);
            Controls.Add(CourseIDLabel);
            ForeColor = Color.White;
            Name = "ShowCourse";
            Text = "ShowCourse";
            FormClosed += ShowCourse_FormClosed;
            Load += ShowCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button BackButton;
        private Button EditCourseButton;
        private Label label5;
        private TextBox username;
        private Label CourseIDLabel;
        private Button RemoveCourseButton;
        private Button EnrollStudentButton;
    }
}