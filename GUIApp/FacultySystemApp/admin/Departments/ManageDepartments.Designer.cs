namespace FacultySystemApp.admin.Departments
{
    partial class ManageDepartments
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
            AddDepartmentButton = new Button();
            ShowAllDepartmentsButton = new Button();
            ShowDepartmentButton = new Button();
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
            BackButton.Location = new Point(27, 25);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 16;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // AddDepartmentButton
            // 
            AddDepartmentButton.BackColor = Color.Transparent;
            AddDepartmentButton.FlatAppearance.BorderSize = 0;
            AddDepartmentButton.FlatStyle = FlatStyle.Flat;
            AddDepartmentButton.Font = new Font("Segoe UI", 20F);
            AddDepartmentButton.ForeColor = Color.Orange;
            AddDepartmentButton.Location = new Point(281, 152);
            AddDepartmentButton.Name = "AddDepartmentButton";
            AddDepartmentButton.Size = new Size(239, 61);
            AddDepartmentButton.TabIndex = 15;
            AddDepartmentButton.Text = "Add Department";
            AddDepartmentButton.UseMnemonic = false;
            AddDepartmentButton.UseVisualStyleBackColor = false;
            AddDepartmentButton.Click += AddDepartmentButton_Click;
            // 
            // ShowAllDepartmentsButton
            // 
            ShowAllDepartmentsButton.BackColor = Color.Transparent;
            ShowAllDepartmentsButton.FlatAppearance.BorderSize = 0;
            ShowAllDepartmentsButton.FlatStyle = FlatStyle.Flat;
            ShowAllDepartmentsButton.Font = new Font("Segoe UI", 20F);
            ShowAllDepartmentsButton.ForeColor = Color.Orange;
            ShowAllDepartmentsButton.Location = new Point(253, 362);
            ShowAllDepartmentsButton.Name = "ShowAllDepartmentsButton";
            ShowAllDepartmentsButton.Size = new Size(295, 53);
            ShowAllDepartmentsButton.TabIndex = 14;
            ShowAllDepartmentsButton.Text = "Show All Departments";
            ShowAllDepartmentsButton.UseVisualStyleBackColor = false;
            ShowAllDepartmentsButton.Click += ShowAllDepartmentsButton_Click;
            // 
            // ShowDepartmentButton
            // 
            ShowDepartmentButton.BackColor = Color.Transparent;
            ShowDepartmentButton.FlatAppearance.BorderSize = 0;
            ShowDepartmentButton.FlatStyle = FlatStyle.Flat;
            ShowDepartmentButton.Font = new Font("Segoe UI", 20F);
            ShowDepartmentButton.ForeColor = Color.Orange;
            ShowDepartmentButton.Location = new Point(274, 252);
            ShowDepartmentButton.Name = "ShowDepartmentButton";
            ShowDepartmentButton.Size = new Size(253, 61);
            ShowDepartmentButton.TabIndex = 13;
            ShowDepartmentButton.Text = "Show Department";
            ShowDepartmentButton.UseVisualStyleBackColor = false;
            ShowDepartmentButton.Click += ShowDepartmentButton_Click;
            // 
            // AdminNameLabel
            // 
            AdminNameLabel.AutoSize = true;
            AdminNameLabel.Font = new Font("Segoe UI", 30F);
            AdminNameLabel.Location = new Point(196, 25);
            AdminNameLabel.Name = "AdminNameLabel";
            AdminNameLabel.Size = new Size(408, 54);
            AdminNameLabel.TabIndex = 12;
            AdminNameLabel.Text = "Manage Departments";
            // 
            // ManageDepartments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(BackButton);
            Controls.Add(AddDepartmentButton);
            Controls.Add(ShowAllDepartmentsButton);
            Controls.Add(ShowDepartmentButton);
            Controls.Add(AdminNameLabel);
            ForeColor = Color.White;
            Name = "ManageDepartments";
            Text = "ManageDepartments";
            FormClosed += ManageDepartments_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button AddDepartmentButton;
        private Button ShowAllDepartmentsButton;
        private Button ShowDepartmentButton;
        private Label AdminNameLabel;
    }
}