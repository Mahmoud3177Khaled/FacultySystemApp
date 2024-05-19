namespace FacultySystemApp.admin.staff
{
    partial class ShowStaff
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
            label8 = new Label();
            textBox1 = new TextBox();
            BackButton = new Button();
            EditButton = new Button();
            label9 = new Label();
            id = new TextBox();
            label5 = new Label();
            lastName = new TextBox();
            middleName = new TextBox();
            firstName = new TextBox();
            StaffIdLabel = new Label();
            Remove = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Segoe UI", 30F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(172, 214);
            label8.Name = "label8";
            label8.Size = new Size(153, 54);
            label8.TabIndex = 115;
            label8.Text = "Staff ID";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(445, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(601, 43);
            textBox1.TabIndex = 114;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(68, 41);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 113;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 20F);
            EditButton.ForeColor = Color.Black;
            EditButton.Location = new Point(363, 441);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(142, 46);
            EditButton.TabIndex = 112;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Segoe UI", 30F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(39, 293);
            label9.Name = "label9";
            label9.Size = new Size(286, 54);
            label9.TabIndex = 111;
            label9.Text = "Department ID";
            // 
            // id
            // 
            id.Enabled = false;
            id.Font = new Font("Segoe UI", 20F);
            id.Location = new Point(445, 293);
            id.Name = "id";
            id.Size = new Size(601, 43);
            id.TabIndex = 110;
            id.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(197, 136);
            label5.Name = "label5";
            label5.Size = new Size(128, 54);
            label5.TabIndex = 109;
            label5.Text = "Name";
            // 
            // lastName
            // 
            lastName.Enabled = false;
            lastName.Font = new Font("Segoe UI", 20F);
            lastName.Location = new Point(856, 136);
            lastName.Name = "lastName";
            lastName.PlaceholderText = "LastName";
            lastName.Size = new Size(190, 43);
            lastName.TabIndex = 108;
            lastName.TextAlign = HorizontalAlignment.Center;
            // 
            // middleName
            // 
            middleName.Enabled = false;
            middleName.Font = new Font("Segoe UI", 20F);
            middleName.Location = new Point(651, 136);
            middleName.Name = "middleName";
            middleName.PlaceholderText = "MiddleName";
            middleName.Size = new Size(190, 43);
            middleName.TabIndex = 107;
            middleName.TextAlign = HorizontalAlignment.Center;
            // 
            // firstName
            // 
            firstName.Enabled = false;
            firstName.Font = new Font("Segoe UI", 20F);
            firstName.Location = new Point(445, 136);
            firstName.Name = "firstName";
            firstName.PlaceholderText = "FirstName";
            firstName.Size = new Size(190, 43);
            firstName.TabIndex = 106;
            firstName.TextAlign = HorizontalAlignment.Center;
            // 
            // StaffIdLabel
            // 
            StaffIdLabel.AutoSize = true;
            StaffIdLabel.Font = new Font("Segoe UI", 30F);
            StaffIdLabel.ForeColor = Color.White;
            StaffIdLabel.Location = new Point(413, 33);
            StaffIdLabel.Name = "StaffIdLabel";
            StaffIdLabel.Size = new Size(168, 54);
            StaffIdLabel.TabIndex = 105;
            StaffIdLabel.Text = "Staff : id";
            // 
            // Remove
            // 
            Remove.Font = new Font("Segoe UI", 20F);
            Remove.ForeColor = Color.Black;
            Remove.Location = new Point(579, 441);
            Remove.Name = "Remove";
            Remove.Size = new Size(142, 46);
            Remove.TabIndex = 116;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            // 
            // ShowStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1084, 541);
            Controls.Add(Remove);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(BackButton);
            Controls.Add(EditButton);
            Controls.Add(label9);
            Controls.Add(id);
            Controls.Add(label5);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(StaffIdLabel);
            ForeColor = Color.White;
            Name = "ShowStaff";
            Text = "ShowStaff";
            FormClosing += ShowStaff_FormClosing;
            Load += ShowStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox textBox1;
        private Button BackButton;
        private Button EditButton;
        private Label label9;
        private TextBox id;
        private Label label5;
        private TextBox lastName;
        private TextBox middleName;
        private TextBox firstName;
        private Label StaffIdLabel;
        private Button Remove;
    }
}