namespace FacultySystemApp.admin.Courses
{
    partial class EditCourse
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
            SaveCourseButton = new Button();
            label5 = new Label();
            username = new TextBox();
            CourseIDLabel = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(385, 338);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(402, 43);
            textBox3.TabIndex = 103;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(385, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(402, 43);
            textBox2.TabIndex = 102;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(385, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 43);
            textBox1.TabIndex = 101;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(144, 192);
            label4.Name = "label4";
            label4.Size = new Size(196, 54);
            label4.TabIndex = 100;
            label4.Text = "Course ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 30F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(93, 263);
            label3.Name = "label3";
            label3.Size = new Size(247, 54);
            label3.TabIndex = 99;
            label3.Text = "Credit Hours";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 30F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 328);
            label2.Name = "label2";
            label2.Size = new Size(286, 54);
            label2.TabIndex = 98;
            label2.Text = "Department ID";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(36, 20);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 97;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SaveCourseButton
            // 
            SaveCourseButton.Font = new Font("Segoe UI", 20F);
            SaveCourseButton.ForeColor = Color.Black;
            SaveCourseButton.Location = new Point(337, 415);
            SaveCourseButton.Name = "SaveCourseButton";
            SaveCourseButton.Size = new Size(90, 46);
            SaveCourseButton.TabIndex = 96;
            SaveCourseButton.Text = "Save";
            SaveCourseButton.UseVisualStyleBackColor = true;
            SaveCourseButton.Click += SaveCourseButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(78, 125);
            label5.Name = "label5";
            label5.Size = new Size(262, 54);
            label5.TabIndex = 95;
            label5.Text = "Course Name";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 20F);
            username.Location = new Point(385, 125);
            username.Name = "username";
            username.Size = new Size(402, 43);
            username.TabIndex = 94;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // CourseIDLabel
            // 
            CourseIDLabel.AutoSize = true;
            CourseIDLabel.Font = new Font("Segoe UI", 25F);
            CourseIDLabel.Location = new Point(255, 21);
            CourseIDLabel.Name = "CourseIDLabel";
            CourseIDLabel.Size = new Size(243, 46);
            CourseIDLabel.TabIndex = 93;
            CourseIDLabel.Text = "Edit Course : id";
            // 
            // EditCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(822, 483);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BackButton);
            Controls.Add(SaveCourseButton);
            Controls.Add(label5);
            Controls.Add(username);
            Controls.Add(CourseIDLabel);
            ForeColor = Color.White;
            Name = "EditCourse";
            Text = "EditCourse";
            FormClosed += EditCourse_FormClosed;
            Load += EditCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnrollStudentButton;
        private Button RemoveCourseButton;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button BackButton;
        private Button SaveCourseButton;
        private Label label5;
        private TextBox username;
        private Label CourseIDLabel;
    }
}