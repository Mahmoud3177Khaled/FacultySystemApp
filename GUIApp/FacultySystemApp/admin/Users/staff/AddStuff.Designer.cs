namespace FacultySystemApp.admin.staff
{
    partial class AddStuff
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
            label9 = new Label();
            DepartmentID = new TextBox();
            label5 = new Label();
            lastName = new TextBox();
            middleName = new TextBox();
            firstName = new TextBox();
            label1 = new Label();
            label8 = new Label();
            id = new TextBox();
            signupButton = new Button();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(57, 18);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 91;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Segoe UI", 30F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(28, 270);
            label9.Name = "label9";
            label9.Size = new Size(286, 54);
            label9.TabIndex = 88;
            label9.Text = "Department ID";
            // 
            // DepartmentID
            // 
            DepartmentID.Font = new Font("Segoe UI", 20F);
            DepartmentID.Location = new Point(434, 270);
            DepartmentID.Name = "DepartmentID";
            DepartmentID.Size = new Size(601, 43);
            DepartmentID.TabIndex = 87;
            DepartmentID.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(186, 113);
            label5.Name = "label5";
            label5.Size = new Size(128, 54);
            label5.TabIndex = 86;
            label5.Text = "Name";
            // 
            // lastName
            // 
            lastName.Font = new Font("Segoe UI", 20F);
            lastName.Location = new Point(845, 113);
            lastName.Name = "lastName";
            lastName.PlaceholderText = "LastName";
            lastName.Size = new Size(190, 43);
            lastName.TabIndex = 85;
            lastName.TextAlign = HorizontalAlignment.Center;
            // 
            // middleName
            // 
            middleName.Font = new Font("Segoe UI", 20F);
            middleName.Location = new Point(640, 113);
            middleName.Name = "middleName";
            middleName.PlaceholderText = "MiddleName";
            middleName.Size = new Size(190, 43);
            middleName.TabIndex = 84;
            middleName.TextAlign = HorizontalAlignment.Center;
            // 
            // firstName
            // 
            firstName.Font = new Font("Segoe UI", 20F);
            firstName.Location = new Point(434, 113);
            firstName.Name = "firstName";
            firstName.PlaceholderText = "FirstName";
            firstName.Size = new Size(190, 43);
            firstName.TabIndex = 83;
            firstName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(437, 10);
            label1.Name = "label1";
            label1.Size = new Size(188, 54);
            label1.TabIndex = 70;
            label1.Text = "Add Staff";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Segoe UI", 30F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(161, 191);
            label8.Name = "label8";
            label8.Size = new Size(153, 54);
            label8.TabIndex = 93;
            label8.Text = "Staff ID";
            // 
            // id
            // 
            id.Font = new Font("Segoe UI", 20F);
            id.Location = new Point(434, 191);
            id.Name = "id";
            id.Size = new Size(601, 43);
            id.TabIndex = 92;
            id.TextAlign = HorizontalAlignment.Center;
            // 
            // signupButton
            // 
            signupButton.Font = new Font("Segoe UI", 20F);
            signupButton.ForeColor = Color.Black;
            signupButton.Location = new Point(460, 390);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(142, 46);
            signupButton.TabIndex = 89;
            signupButton.Text = "Signup";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // AddStuff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1062, 484);
            Controls.Add(label8);
            Controls.Add(id);
            Controls.Add(BackButton);
            Controls.Add(signupButton);
            Controls.Add(label9);
            Controls.Add(DepartmentID);
            Controls.Add(label5);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "AddStuff";
            Text = "AddStuff";
            FormClosed += AddStuff_FormClosed;
            Load += AddStuff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label label9;
        private TextBox DepartmentID;
        private Label label5;
        private TextBox lastName;
        private TextBox middleName;
        private TextBox firstName;
        private Label label1;
        private Label label8;
        private TextBox id;
        private Button signupButton;
    }
}