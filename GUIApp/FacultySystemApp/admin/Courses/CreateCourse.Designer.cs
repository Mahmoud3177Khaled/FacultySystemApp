namespace FacultySystemApp.admin.Courses
{
    partial class CreateCourse
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
            CreateCourseButton = new Button();
            label5 = new Label();
            username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(264, 32);
            label1.Name = "label1";
            label1.Size = new Size(231, 46);
            label1.TabIndex = 0;
            label1.Text = "Create Course";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(27, 31);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 73;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // CreateCourseButton
            // 
            CreateCourseButton.Font = new Font("Segoe UI", 20F);
            CreateCourseButton.ForeColor = Color.Black;
            CreateCourseButton.Location = new Point(320, 439);
            CreateCourseButton.Name = "CreateCourseButton";
            CreateCourseButton.Size = new Size(142, 46);
            CreateCourseButton.TabIndex = 72;
            CreateCourseButton.Text = "Create";
            CreateCourseButton.UseVisualStyleBackColor = true;
            CreateCourseButton.Click += CreateCourseButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(69, 136);
            label5.Name = "label5";
            label5.Size = new Size(262, 54);
            label5.TabIndex = 71;
            label5.Text = "Course Name";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 20F);
            username.Location = new Point(376, 136);
            username.Name = "username";
            username.Size = new Size(402, 43);
            username.TabIndex = 70;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 30F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 339);
            label2.Name = "label2";
            label2.Size = new Size(286, 54);
            label2.TabIndex = 74;
            label2.Text = "Department ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 30F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(84, 274);
            label3.Name = "label3";
            label3.Size = new Size(247, 54);
            label3.TabIndex = 75;
            label3.Text = "Credit Hours";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(135, 203);
            label4.Name = "label4";
            label4.Size = new Size(196, 54);
            label4.TabIndex = 76;
            label4.Text = "Course ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(376, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 43);
            textBox1.TabIndex = 77;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(376, 285);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(402, 43);
            textBox2.TabIndex = 78;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(376, 349);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(402, 43);
            textBox3.TabIndex = 79;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // CreateCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(823, 535);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BackButton);
            Controls.Add(CreateCourseButton);
            Controls.Add(label5);
            Controls.Add(username);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "CreateCourse";
            Text = "CreateCourse";
            FormClosed += CreateCourse_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BackButton;
        private Button CreateCourseButton;
        private Label label5;
        private TextBox username;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}