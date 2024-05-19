namespace FacultySystemApp.student
{
    partial class EditStudentProfile
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
            SaveButton = new Button();
            label5 = new Label();
            lastName = new TextBox();
            middleName = new TextBox();
            firstName = new TextBox();
            label7 = new Label();
            phone2 = new TextBox();
            label4 = new Label();
            Password = new TextBox();
            label3 = new Label();
            Address = new TextBox();
            label6 = new Label();
            phone1 = new TextBox();
            StudentIdLabel = new Label();
            BackButton = new Button();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 20F);
            SaveButton.ForeColor = Color.Black;
            SaveButton.Location = new Point(449, 512);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(142, 46);
            SaveButton.TabIndex = 139;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(124, 101);
            label5.Name = "label5";
            label5.Size = new Size(128, 54);
            label5.TabIndex = 134;
            label5.Text = "Name";
            // 
            // lastName
            // 
            lastName.Enabled = false;
            lastName.Font = new Font("Segoe UI", 20F);
            lastName.Location = new Point(804, 101);
            lastName.Name = "lastName";
            lastName.PlaceholderText = "LastName";
            lastName.Size = new Size(190, 43);
            lastName.TabIndex = 133;
            lastName.TextAlign = HorizontalAlignment.Center;
            // 
            // middleName
            // 
            middleName.Enabled = false;
            middleName.Font = new Font("Segoe UI", 20F);
            middleName.Location = new Point(599, 101);
            middleName.Name = "middleName";
            middleName.PlaceholderText = "MiddleName";
            middleName.Size = new Size(190, 43);
            middleName.TabIndex = 132;
            middleName.TextAlign = HorizontalAlignment.Center;
            // 
            // firstName
            // 
            firstName.Enabled = false;
            firstName.Font = new Font("Segoe UI", 20F);
            firstName.Location = new Point(393, 101);
            firstName.Name = "firstName";
            firstName.PlaceholderText = "FirstName";
            firstName.Size = new Size(190, 43);
            firstName.TabIndex = 131;
            firstName.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Segoe UI", 30F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 336);
            label7.Name = "label7";
            label7.Size = new Size(244, 54);
            label7.TabIndex = 128;
            label7.Text = "PhoneNum2";
            // 
            // phone2
            // 
            phone2.Font = new Font("Segoe UI", 20F);
            phone2.Location = new Point(393, 336);
            phone2.Name = "phone2";
            phone2.Size = new Size(601, 43);
            phone2.TabIndex = 127;
            phone2.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(80, 414);
            label4.Name = "label4";
            label4.Size = new Size(188, 54);
            label4.TabIndex = 126;
            label4.Text = "Password";
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 20F);
            Password.Location = new Point(393, 414);
            Password.Name = "Password";
            Password.Size = new Size(601, 43);
            Password.TabIndex = 125;
            Password.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 30F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(102, 179);
            label3.Name = "label3";
            label3.Size = new Size(166, 54);
            label3.TabIndex = 124;
            label3.Text = "Address";
            // 
            // Address
            // 
            Address.Font = new Font("Segoe UI", 20F);
            Address.Location = new Point(393, 179);
            Address.Name = "Address";
            Address.Size = new Size(601, 43);
            Address.TabIndex = 123;
            Address.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 30F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 258);
            label6.Name = "label6";
            label6.Size = new Size(244, 54);
            label6.TabIndex = 120;
            label6.Text = "PhoneNum1";
            // 
            // phone1
            // 
            phone1.Font = new Font("Segoe UI", 20F);
            phone1.Location = new Point(393, 258);
            phone1.Name = "phone1";
            phone1.Size = new Size(601, 43);
            phone1.TabIndex = 119;
            phone1.TextAlign = HorizontalAlignment.Center;
            // 
            // StudentIdLabel
            // 
            StudentIdLabel.AutoSize = true;
            StudentIdLabel.Font = new Font("Segoe UI", 30F);
            StudentIdLabel.ForeColor = Color.White;
            StudentIdLabel.Location = new Point(393, 21);
            StudentIdLabel.Name = "StudentIdLabel";
            StudentIdLabel.Size = new Size(260, 54);
            StudentIdLabel.TabIndex = 118;
            StudentIdLabel.Text = "Edit id Profile";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(30, 21);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 140;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // EditStudentProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1047, 594);
            Controls.Add(BackButton);
            Controls.Add(SaveButton);
            Controls.Add(label5);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(label7);
            Controls.Add(phone2);
            Controls.Add(label4);
            Controls.Add(Password);
            Controls.Add(label3);
            Controls.Add(Address);
            Controls.Add(label6);
            Controls.Add(phone1);
            Controls.Add(StudentIdLabel);
            ForeColor = Color.White;
            Name = "EditStudentProfile";
            Text = "EditStudentProfile";
            FormClosed += EditStudentProfile_FormClosed;
            Load += EditStudentProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ShowEnrollingCourses;
        private Button SaveButton;
        private TextBox textBox1;
        private Label label10;
        private Label label9;
        private TextBox id;
        private Label label5;
        private TextBox lastName;
        private TextBox middleName;
        private TextBox firstName;
        private Label label8;
        private TextBox username;
        private Label label7;
        private TextBox phone2;
        private Label label4;
        private TextBox Password;
        private Label label3;
        private TextBox Address;
        private Label label2;
        private TextBox Email;
        private Label label6;
        private TextBox phone1;
        private Label StudentIdLabel;
        private Button BackButton;
    }
}