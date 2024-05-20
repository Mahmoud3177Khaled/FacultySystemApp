namespace FacultySystemApp.admin.students
{
    partial class EditStudent
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
            departmentID = new TextBox();
            label10 = new Label();
            label5 = new Label();
            lastName = new TextBox();
            middleName = new TextBox();
            firstName = new TextBox();
            label8 = new Label();
            username = new TextBox();
            label4 = new Label();
            Password = new TextBox();
            label3 = new Label();
            Address = new TextBox();
            label2 = new Label();
            Email = new TextBox();
            StudentIdLabel = new Label();
            label11 = new Label();
            BackButton = new Button();
            EntryYear = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 20F);
            SaveButton.ForeColor = Color.Black;
            SaveButton.Location = new Point(464, 688);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(142, 46);
            SaveButton.TabIndex = 67;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // departmentID
            // 
            departmentID.Font = new Font("Segoe UI", 20F);
            departmentID.Location = new Point(447, 523);
            departmentID.Name = "departmentID";
            departmentID.Size = new Size(601, 43);
            departmentID.TabIndex = 66;
            departmentID.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Black;
            label10.Font = new Font("Segoe UI", 30F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(41, 513);
            label10.Name = "label10";
            label10.Size = new Size(286, 54);
            label10.TabIndex = 65;
            label10.Text = "Department ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(178, 132);
            label5.Name = "label5";
            label5.Size = new Size(128, 54);
            label5.TabIndex = 62;
            label5.Text = "Name";
            // 
            // lastName
            // 
            lastName.Font = new Font("Segoe UI", 20F);
            lastName.Location = new Point(858, 132);
            lastName.Name = "lastName";
            lastName.PlaceholderText = "LastName";
            lastName.Size = new Size(190, 43);
            lastName.TabIndex = 61;
            lastName.TextAlign = HorizontalAlignment.Center;
            // 
            // middleName
            // 
            middleName.Font = new Font("Segoe UI", 20F);
            middleName.Location = new Point(653, 132);
            middleName.Name = "middleName";
            middleName.PlaceholderText = "MiddleName";
            middleName.Size = new Size(190, 43);
            middleName.TabIndex = 60;
            middleName.TextAlign = HorizontalAlignment.Center;
            // 
            // firstName
            // 
            firstName.Font = new Font("Segoe UI", 20F);
            firstName.Location = new Point(447, 132);
            firstName.Name = "firstName";
            firstName.PlaceholderText = "FirstName";
            firstName.Size = new Size(190, 43);
            firstName.TabIndex = 59;
            firstName.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Segoe UI", 30F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(126, 213);
            label8.Name = "label8";
            label8.Size = new Size(196, 54);
            label8.TabIndex = 58;
            label8.Text = "username";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 20F);
            username.Location = new Point(447, 213);
            username.Name = "username";
            username.Size = new Size(601, 43);
            username.TabIndex = 57;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(134, 441);
            label4.Name = "label4";
            label4.Size = new Size(188, 54);
            label4.TabIndex = 54;
            label4.Text = "Password";
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 20F);
            Password.Location = new Point(447, 441);
            Password.Name = "Password";
            Password.Size = new Size(601, 43);
            Password.TabIndex = 53;
            Password.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 30F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(156, 291);
            label3.Name = "label3";
            label3.Size = new Size(166, 54);
            label3.TabIndex = 52;
            label3.Text = "Address";
            // 
            // Address
            // 
            Address.Font = new Font("Segoe UI", 20F);
            Address.Location = new Point(447, 291);
            Address.Name = "Address";
            Address.Size = new Size(601, 43);
            Address.TabIndex = 51;
            Address.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 30F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(205, 368);
            label2.Name = "label2";
            label2.Size = new Size(117, 54);
            label2.TabIndex = 50;
            label2.Text = "Email";
            // 
            // Email
            // 
            Email.Font = new Font("Segoe UI", 20F);
            Email.Location = new Point(447, 368);
            Email.Name = "Email";
            Email.Size = new Size(601, 43);
            Email.TabIndex = 49;
            Email.TextAlign = HorizontalAlignment.Center;
            // 
            // StudentIdLabel
            // 
            StudentIdLabel.AutoSize = true;
            StudentIdLabel.Font = new Font("Segoe UI", 30F);
            StudentIdLabel.ForeColor = Color.White;
            StudentIdLabel.Location = new Point(332, 24);
            StudentIdLabel.Name = "StudentIdLabel";
            StudentIdLabel.Size = new Size(306, 54);
            StudentIdLabel.TabIndex = 46;
            StudentIdLabel.Text = "Edit Student : id";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Black;
            label11.Font = new Font("Segoe UI", 30F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(572, 704);
            label11.Name = "label11";
            label11.Size = new Size(34, 54);
            label11.TabIndex = 68;
            label11.Text = " ";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(38, 24);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 69;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // EntryYear
            // 
            EntryYear.Font = new Font("Segoe UI", 20F);
            EntryYear.Location = new Point(447, 606);
            EntryYear.Name = "EntryYear";
            EntryYear.Size = new Size(601, 43);
            EntryYear.TabIndex = 73;
            EntryYear.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 595);
            label1.Name = "label1";
            label1.Size = new Size(197, 54);
            label1.TabIndex = 72;
            label1.Text = "Entry Year";
            // 
            // EditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1121, 660);
            Controls.Add(EntryYear);
            Controls.Add(label1);
            Controls.Add(BackButton);
            Controls.Add(departmentID);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(label8);
            Controls.Add(username);
            Controls.Add(label4);
            Controls.Add(Password);
            Controls.Add(label3);
            Controls.Add(Address);
            Controls.Add(label2);
            Controls.Add(Email);
            Controls.Add(StudentIdLabel);
            Controls.Add(SaveButton);
            Controls.Add(label11);
            ForeColor = Color.White;
            Name = "EditStudent";
            Text = "EditStudent";
            FormClosed += EditStudent_close;
            Load += EditStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private TextBox departmentID;
        private Label label10;
        private Label label5;
        private TextBox lastName;
        private TextBox middleName;
        private TextBox firstName;
        private Label label8;
        private TextBox username;
        private Label label4;
        private TextBox Password;
        private Label label3;
        private TextBox Address;
        private Label label2;
        private TextBox Email;
        private Label StudentIdLabel;
        private Label label11;
        private Button BackButton;
        private TextBox EntryYear;
        private Label label1;
    }
}