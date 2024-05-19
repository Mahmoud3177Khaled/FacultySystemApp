namespace FacultySystemApp.admin
{
    partial class ManageCourses
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
            CreateCourseButton = new Button();
            ShowAllCoursesButton = new Button();
            ShowCourseButton = new Button();
            AdminNameLabel = new Label();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(59, 18);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 11;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // CreateCourseButton
            // 
            CreateCourseButton.BackColor = Color.Transparent;
            CreateCourseButton.FlatAppearance.BorderSize = 0;
            CreateCourseButton.FlatStyle = FlatStyle.Flat;
            CreateCourseButton.Font = new Font("Segoe UI", 20F);
            CreateCourseButton.ForeColor = Color.Orange;
            CreateCourseButton.Location = new Point(334, 161);
            CreateCourseButton.Name = "CreateCourseButton";
            CreateCourseButton.Size = new Size(195, 61);
            CreateCourseButton.TabIndex = 10;
            CreateCourseButton.Text = "Create Course";
            CreateCourseButton.UseMnemonic = false;
            CreateCourseButton.UseVisualStyleBackColor = false;
            CreateCourseButton.Click += CreateCourseButton_Click;
            // 
            // ShowAllCoursesButton
            // 
            ShowAllCoursesButton.BackColor = Color.Transparent;
            ShowAllCoursesButton.FlatAppearance.BorderSize = 0;
            ShowAllCoursesButton.FlatStyle = FlatStyle.Flat;
            ShowAllCoursesButton.Font = new Font("Segoe UI", 20F);
            ShowAllCoursesButton.ForeColor = Color.Orange;
            ShowAllCoursesButton.Location = new Point(289, 370);
            ShowAllCoursesButton.Name = "ShowAllCoursesButton";
            ShowAllCoursesButton.Size = new Size(284, 53);
            ShowAllCoursesButton.TabIndex = 9;
            ShowAllCoursesButton.Text = "Show All Courses";
            ShowAllCoursesButton.UseVisualStyleBackColor = false;
            ShowAllCoursesButton.Click += ShowAllCoursesButton_Click;
            // 
            // ShowCourseButton
            // 
            ShowCourseButton.BackColor = Color.Transparent;
            ShowCourseButton.FlatAppearance.BorderSize = 0;
            ShowCourseButton.FlatStyle = FlatStyle.Flat;
            ShowCourseButton.Font = new Font("Segoe UI", 20F);
            ShowCourseButton.ForeColor = Color.Orange;
            ShowCourseButton.Location = new Point(320, 263);
            ShowCourseButton.Name = "ShowCourseButton";
            ShowCourseButton.Size = new Size(223, 61);
            ShowCourseButton.TabIndex = 7;
            ShowCourseButton.Text = "Show Course";
            ShowCourseButton.UseVisualStyleBackColor = false;
            ShowCourseButton.Click += ShowCourseButton_Click;
            // 
            // AdminNameLabel
            // 
            AdminNameLabel.AutoSize = true;
            AdminNameLabel.Font = new Font("Segoe UI", 30F);
            AdminNameLabel.Location = new Point(272, 33);
            AdminNameLabel.Name = "AdminNameLabel";
            AdminNameLabel.Size = new Size(318, 54);
            AdminNameLabel.TabIndex = 6;
            AdminNameLabel.Text = "Manage Courses";
            // 
            // ManageCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(863, 485);
            Controls.Add(BackButton);
            Controls.Add(CreateCourseButton);
            Controls.Add(ShowAllCoursesButton);
            Controls.Add(ShowCourseButton);
            Controls.Add(AdminNameLabel);
            ForeColor = Color.White;
            Name = "ManageCourses";
            Text = "ManageCourses";
            FormClosed += ManageCourses_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button CreateCourseButton;
        private Button ShowAllCoursesButton;
        private Button ShowCourseButton;
        private Label AdminNameLabel;
    }
}