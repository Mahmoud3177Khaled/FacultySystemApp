namespace FacultySystemApp.admin.staff
{
    partial class EditStaff
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
            SaveButton = new Button();
            label9 = new Label();
            id = new TextBox();
            label5 = new Label();
            lastName = new TextBox();
            middleName = new TextBox();
            firstName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Segoe UI", 30F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(159, 193);
            label8.Name = "label8";
            label8.Size = new Size(153, 54);
            label8.TabIndex = 104;
            label8.Text = "Staff ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(432, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(601, 43);
            textBox1.TabIndex = 103;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(55, 20);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 102;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 20F);
            SaveButton.ForeColor = Color.Black;
            SaveButton.Location = new Point(432, 420);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(142, 46);
            SaveButton.TabIndex = 101;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Segoe UI", 30F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(26, 272);
            label9.Name = "label9";
            label9.Size = new Size(286, 54);
            label9.TabIndex = 100;
            label9.Text = "Department ID";
            // 
            // id
            // 
            id.Font = new Font("Segoe UI", 20F);
            id.Location = new Point(432, 272);
            id.Name = "id";
            id.Size = new Size(601, 43);
            id.TabIndex = 99;
            id.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(184, 115);
            label5.Name = "label5";
            label5.Size = new Size(128, 54);
            label5.TabIndex = 98;
            label5.Text = "Name";
            // 
            // lastName
            // 
            lastName.Font = new Font("Segoe UI", 20F);
            lastName.Location = new Point(843, 115);
            lastName.Name = "lastName";
            lastName.PlaceholderText = "LastName";
            lastName.Size = new Size(190, 43);
            lastName.TabIndex = 97;
            lastName.TextAlign = HorizontalAlignment.Center;
            // 
            // middleName
            // 
            middleName.Font = new Font("Segoe UI", 20F);
            middleName.Location = new Point(638, 115);
            middleName.Name = "middleName";
            middleName.PlaceholderText = "MiddleName";
            middleName.Size = new Size(190, 43);
            middleName.TabIndex = 96;
            middleName.TextAlign = HorizontalAlignment.Center;
            // 
            // firstName
            // 
            firstName.Font = new Font("Segoe UI", 20F);
            firstName.Location = new Point(432, 115);
            firstName.Name = "firstName";
            firstName.PlaceholderText = "FirstName";
            firstName.Size = new Size(190, 43);
            firstName.TabIndex = 95;
            firstName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(338, 13);
            label1.Name = "label1";
            label1.Size = new Size(247, 54);
            label1.TabIndex = 94;
            label1.Text = "Edit Staff : id";
            // 
            // EditStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1058, 527);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(BackButton);
            Controls.Add(SaveButton);
            Controls.Add(label9);
            Controls.Add(id);
            Controls.Add(label5);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "EditStaff";
            Text = "EditStaff";
            FormClosed += EditStaff_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private TextBox textBox1;
        private Button BackButton;
        private Button SaveButton;
        private Label label9;
        private TextBox id;
        private Label label5;
        private TextBox lastName;
        private TextBox middleName;
        private TextBox firstName;
        private Label label1;
    }
}