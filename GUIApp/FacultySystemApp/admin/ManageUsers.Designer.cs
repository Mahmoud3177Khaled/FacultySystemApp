namespace FacultySystemApp.admin
{
    partial class ManageUsers
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SignupStudent = new Button();
            ShowStudent = new Button();
            ShowAllStudents = new Button();
            ShowAllAdmins = new Button();
            ShowAdmin = new Button();
            SignupAdmin = new Button();
            ShowAllStaff = new Button();
            ShowStaff = new Button();
            AddStuff = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(325, 45);
            label1.Name = "label1";
            label1.Size = new Size(218, 46);
            label1.TabIndex = 0;
            label1.Text = "Manage User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(85, 165);
            label2.Name = "label2";
            label2.Size = new Size(121, 37);
            label2.TabIndex = 1;
            label2.Text = "Student :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(98, 359);
            label3.Name = "label3";
            label3.Size = new Size(108, 37);
            label3.TabIndex = 2;
            label3.Text = "Admin :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(124, 263);
            label4.Name = "label4";
            label4.Size = new Size(82, 37);
            label4.TabIndex = 3;
            label4.Text = "Staff :";
            // 
            // SignupStudent
            // 
            SignupStudent.FlatAppearance.BorderColor = Color.Red;
            SignupStudent.FlatAppearance.BorderSize = 0;
            SignupStudent.FlatStyle = FlatStyle.Flat;
            SignupStudent.Font = new Font("Segoe UI", 15F);
            SignupStudent.ForeColor = Color.Lime;
            SignupStudent.Location = new Point(270, 165);
            SignupStudent.Name = "SignupStudent";
            SignupStudent.Size = new Size(96, 38);
            SignupStudent.TabIndex = 4;
            SignupStudent.Text = "Signup";
            SignupStudent.UseVisualStyleBackColor = true;
            SignupStudent.Click += SignupStudent_Click;
            // 
            // ShowStudent
            // 
            ShowStudent.FlatAppearance.BorderSize = 0;
            ShowStudent.FlatStyle = FlatStyle.Flat;
            ShowStudent.Font = new Font("Segoe UI", 15F);
            ShowStudent.ForeColor = Color.Blue;
            ShowStudent.Location = new Point(477, 167);
            ShowStudent.Name = "ShowStudent";
            ShowStudent.Size = new Size(96, 38);
            ShowStudent.TabIndex = 5;
            ShowStudent.Text = "Show";
            ShowStudent.UseVisualStyleBackColor = true;
            ShowStudent.Click += ShowStudent_Click;
            // 
            // ShowAllStudents
            // 
            ShowAllStudents.FlatAppearance.BorderSize = 0;
            ShowAllStudents.FlatStyle = FlatStyle.Flat;
            ShowAllStudents.Font = new Font("Segoe UI", 15F);
            ShowAllStudents.ForeColor = Color.Yellow;
            ShowAllStudents.Location = new Point(716, 165);
            ShowAllStudents.Name = "ShowAllStudents";
            ShowAllStudents.Size = new Size(96, 38);
            ShowAllStudents.TabIndex = 7;
            ShowAllStudents.Text = "ShowAll";
            ShowAllStudents.UseVisualStyleBackColor = true;
            ShowAllStudents.Click += ShowAllStudents_Click;
            // 
            // ShowAllAdmins
            // 
            ShowAllAdmins.FlatAppearance.BorderSize = 0;
            ShowAllAdmins.FlatStyle = FlatStyle.Flat;
            ShowAllAdmins.Font = new Font("Segoe UI", 15F);
            ShowAllAdmins.ForeColor = Color.Yellow;
            ShowAllAdmins.Location = new Point(716, 359);
            ShowAllAdmins.Name = "ShowAllAdmins";
            ShowAllAdmins.Size = new Size(96, 38);
            ShowAllAdmins.TabIndex = 11;
            ShowAllAdmins.Text = "ShowAll";
            ShowAllAdmins.UseVisualStyleBackColor = true;
            ShowAllAdmins.Click += ShowAllAdmins_Click;
            // 
            // ShowAdmin
            // 
            ShowAdmin.FlatAppearance.BorderSize = 0;
            ShowAdmin.FlatStyle = FlatStyle.Flat;
            ShowAdmin.Font = new Font("Segoe UI", 15F);
            ShowAdmin.ForeColor = Color.Blue;
            ShowAdmin.Location = new Point(477, 358);
            ShowAdmin.Name = "ShowAdmin";
            ShowAdmin.Size = new Size(96, 38);
            ShowAdmin.TabIndex = 9;
            ShowAdmin.Text = "Show";
            ShowAdmin.UseVisualStyleBackColor = true;
            ShowAdmin.Click += ShowAdmin_Click;
            // 
            // SignupAdmin
            // 
            SignupAdmin.FlatAppearance.BorderColor = Color.Red;
            SignupAdmin.FlatAppearance.BorderSize = 0;
            SignupAdmin.FlatStyle = FlatStyle.Flat;
            SignupAdmin.Font = new Font("Segoe UI", 15F);
            SignupAdmin.ForeColor = Color.Lime;
            SignupAdmin.Location = new Point(270, 359);
            SignupAdmin.Name = "SignupAdmin";
            SignupAdmin.Size = new Size(96, 38);
            SignupAdmin.TabIndex = 8;
            SignupAdmin.Text = "Signup";
            SignupAdmin.UseVisualStyleBackColor = true;
            SignupAdmin.Click += SignupAdmin_Click;
            // 
            // ShowAllStaff
            // 
            ShowAllStaff.FlatAppearance.BorderSize = 0;
            ShowAllStaff.FlatStyle = FlatStyle.Flat;
            ShowAllStaff.Font = new Font("Segoe UI", 15F);
            ShowAllStaff.ForeColor = Color.Yellow;
            ShowAllStaff.Location = new Point(716, 263);
            ShowAllStaff.Name = "ShowAllStaff";
            ShowAllStaff.Size = new Size(96, 38);
            ShowAllStaff.TabIndex = 15;
            ShowAllStaff.Text = "ShowAll";
            ShowAllStaff.UseVisualStyleBackColor = true;
            ShowAllStaff.Click += ShowAllStaff_Click;
            // 
            // ShowStaff
            // 
            ShowStaff.FlatAppearance.BorderSize = 0;
            ShowStaff.FlatStyle = FlatStyle.Flat;
            ShowStaff.Font = new Font("Segoe UI", 15F);
            ShowStaff.ForeColor = Color.Blue;
            ShowStaff.Location = new Point(477, 263);
            ShowStaff.Name = "ShowStaff";
            ShowStaff.Size = new Size(96, 38);
            ShowStaff.TabIndex = 13;
            ShowStaff.Text = "Show";
            ShowStaff.UseVisualStyleBackColor = true;
            ShowStaff.Click += ShowStaff_Click;
            // 
            // AddStuff
            // 
            AddStuff.FlatAppearance.BorderColor = Color.Red;
            AddStuff.FlatAppearance.BorderSize = 0;
            AddStuff.FlatStyle = FlatStyle.Flat;
            AddStuff.Font = new Font("Segoe UI", 15F);
            AddStuff.ForeColor = Color.Lime;
            AddStuff.Location = new Point(270, 263);
            AddStuff.Name = "AddStuff";
            AddStuff.Size = new Size(96, 38);
            AddStuff.TabIndex = 12;
            AddStuff.Text = "Add";
            AddStuff.UseVisualStyleBackColor = true;
            AddStuff.Click += AddStuff_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(30, 24);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 16;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(888, 492);
            Controls.Add(BackButton);
            Controls.Add(ShowAllStaff);
            Controls.Add(ShowStaff);
            Controls.Add(AddStuff);
            Controls.Add(ShowAllAdmins);
            Controls.Add(ShowAdmin);
            Controls.Add(SignupAdmin);
            Controls.Add(ShowAllStudents);
            Controls.Add(ShowStudent);
            Controls.Add(SignupStudent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "ManageUsers";
            Text = "ManageUsers";
            FormClosed += ManageUsers_close;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SignupStudent;
        private Button ShowAllStudents;
        private Button ShowAllAdmins;
        private Button ShowAdmin;
        private Button SignupAdmin;
        private Button ShowAllStaff;
        private Button ShowStaff;
        private Button AddStuff;
        internal Button ShowStudent;
        private Button BackButton;
    }
}