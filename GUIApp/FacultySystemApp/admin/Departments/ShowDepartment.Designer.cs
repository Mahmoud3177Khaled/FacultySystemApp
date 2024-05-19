namespace FacultySystemApp.admin.Departments
{
    partial class ShowDepartment
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
            label2 = new Label();
            BackButton = new Button();
            EditDepartmentButton = new Button();
            label5 = new Label();
            username = new TextBox();
            DepartmentLabel = new Label();
            AssignStudentButton = new Button();
            RemoveButton = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(374, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(402, 43);
            textBox3.TabIndex = 104;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 30F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 136);
            label2.Name = "label2";
            label2.Size = new Size(286, 54);
            label2.TabIndex = 103;
            label2.Text = "Department ID";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(25, 27);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 102;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // EditDepartmentButton
            // 
            EditDepartmentButton.Font = new Font("Segoe UI", 20F);
            EditDepartmentButton.ForeColor = Color.Black;
            EditDepartmentButton.Location = new Point(115, 375);
            EditDepartmentButton.Name = "EditDepartmentButton";
            EditDepartmentButton.Size = new Size(142, 46);
            EditDepartmentButton.TabIndex = 101;
            EditDepartmentButton.Text = "Edit";
            EditDepartmentButton.UseVisualStyleBackColor = true;
            EditDepartmentButton.Click += EditDepartmentButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(67, 240);
            label5.Name = "label5";
            label5.Size = new Size(262, 54);
            label5.TabIndex = 100;
            label5.Text = "Course Name";
            // 
            // username
            // 
            username.Enabled = false;
            username.Font = new Font("Segoe UI", 20F);
            username.Location = new Point(374, 240);
            username.Name = "username";
            username.Size = new Size(402, 43);
            username.TabIndex = 99;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // DepartmentLabel
            // 
            DepartmentLabel.AutoSize = true;
            DepartmentLabel.Font = new Font("Segoe UI", 25F);
            DepartmentLabel.Location = new Point(217, 28);
            DepartmentLabel.Name = "DepartmentLabel";
            DepartmentLabel.Size = new Size(254, 46);
            DepartmentLabel.TabIndex = 98;
            DepartmentLabel.Text = "Department : id";
            // 
            // AssignStudentButton
            // 
            AssignStudentButton.Font = new Font("Segoe UI", 20F);
            AssignStudentButton.ForeColor = Color.Black;
            AssignStudentButton.Location = new Point(297, 375);
            AssignStudentButton.Name = "AssignStudentButton";
            AssignStudentButton.Size = new Size(206, 46);
            AssignStudentButton.TabIndex = 105;
            AssignStudentButton.Text = "Assign Student";
            AssignStudentButton.UseVisualStyleBackColor = true;
            AssignStudentButton.Click += AssignStudentButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Segoe UI", 20F);
            RemoveButton.ForeColor = Color.Black;
            RemoveButton.Location = new Point(543, 375);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(142, 46);
            RemoveButton.TabIndex = 106;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // ShowDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveButton);
            Controls.Add(AssignStudentButton);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(BackButton);
            Controls.Add(EditDepartmentButton);
            Controls.Add(label5);
            Controls.Add(username);
            Controls.Add(DepartmentLabel);
            ForeColor = Color.White;
            Name = "ShowDepartment";
            Text = "ShowDepartment";
            FormClosed += ShowDepartment_FormClosed;
            Load += ShowDepartment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label2;
        private Button BackButton;
        private Button EditDepartmentButton;
        private Label label5;
        private TextBox username;
        private Label DepartmentLabel;
        private Button AssignStudentButton;
        private Button RemoveButton;
    }
}