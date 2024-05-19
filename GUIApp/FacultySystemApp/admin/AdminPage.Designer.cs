namespace FacultySystemApp.admin
{
    partial class AdminPage
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
            AdminNameLabel = new Label();
            ManageCoursesButton = new Button();
            label1 = new Label();
            ManageDepartmentsButton = new Button();
            ManageUsersButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // AdminNameLabel
            // 
            AdminNameLabel.AutoSize = true;
            AdminNameLabel.Font = new Font("Segoe UI", 30F);
            AdminNameLabel.Location = new Point(290, 39);
            AdminNameLabel.Name = "AdminNameLabel";
            AdminNameLabel.Size = new Size(422, 54);
            AdminNameLabel.TabIndex = 0;
            AdminNameLabel.Text = "Welcome Admin name";
            // 
            // ManageCoursesButton
            // 
            ManageCoursesButton.BackColor = Color.Transparent;
            ManageCoursesButton.FlatAppearance.BorderSize = 0;
            ManageCoursesButton.FlatStyle = FlatStyle.Flat;
            ManageCoursesButton.Font = new Font("Segoe UI", 20F);
            ManageCoursesButton.ForeColor = Color.Orange;
            ManageCoursesButton.Location = new Point(366, 293);
            ManageCoursesButton.Name = "ManageCoursesButton";
            ManageCoursesButton.Size = new Size(223, 61);
            ManageCoursesButton.TabIndex = 1;
            ManageCoursesButton.Text = "Manage Courses";
            ManageCoursesButton.UseVisualStyleBackColor = false;
            ManageCoursesButton.Click += ManageCoursesButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(75, 159);
            label1.Name = "label1";
            label1.Size = new Size(175, 54);
            label1.TabIndex = 2;
            label1.Text = "You Can:";
            // 
            // ManageDepartmentsButton
            // 
            ManageDepartmentsButton.BackColor = Color.Transparent;
            ManageDepartmentsButton.FlatAppearance.BorderSize = 0;
            ManageDepartmentsButton.FlatStyle = FlatStyle.Flat;
            ManageDepartmentsButton.Font = new Font("Segoe UI", 20F);
            ManageDepartmentsButton.ForeColor = Color.Orange;
            ManageDepartmentsButton.Location = new Point(366, 386);
            ManageDepartmentsButton.Name = "ManageDepartmentsButton";
            ManageDepartmentsButton.Size = new Size(284, 53);
            ManageDepartmentsButton.TabIndex = 3;
            ManageDepartmentsButton.Text = "Manage Departments";
            ManageDepartmentsButton.UseVisualStyleBackColor = false;
            ManageDepartmentsButton.Click += ManageDepartmentsButton_Click;
            // 
            // ManageUsersButton
            // 
            ManageUsersButton.BackColor = Color.Transparent;
            ManageUsersButton.FlatAppearance.BorderSize = 0;
            ManageUsersButton.FlatStyle = FlatStyle.Flat;
            ManageUsersButton.Font = new Font("Segoe UI", 20F);
            ManageUsersButton.ForeColor = Color.Orange;
            ManageUsersButton.Location = new Point(366, 203);
            ManageUsersButton.Name = "ManageUsersButton";
            ManageUsersButton.Size = new Size(195, 61);
            ManageUsersButton.TabIndex = 4;
            ManageUsersButton.Text = "Manage Users";
            ManageUsersButton.UseMnemonic = false;
            ManageUsersButton.UseVisualStyleBackColor = false;
            ManageUsersButton.Click += ManageUsersButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(30, 25);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 5;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1041, 565);
            Controls.Add(BackButton);
            Controls.Add(ManageUsersButton);
            Controls.Add(ManageDepartmentsButton);
            Controls.Add(label1);
            Controls.Add(ManageCoursesButton);
            Controls.Add(AdminNameLabel);
            ForeColor = Color.White;
            Name = "AdminPage";
            Text = " AdminPage";
            FormClosed += AdminPageClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AdminNameLabel;
        private Button ManageCoursesButton;
        private Label label1;
        private Button ManageDepartmentsButton;
        private Button ManageUsersButton;
        private Button BackButton;
    }
}