namespace FacultySystemApp.admin.Departments
{
    partial class ShowAllDepartments
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
            label1 = new Label();
            Departments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Departments).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(33, 26);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 76;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(284, 25);
            label1.Name = "label1";
            label1.Size = new Size(262, 46);
            label1.TabIndex = 75;
            label1.Text = "All Departments";
            // 
            // Departments
            // 
            Departments.AllowUserToAddRows = false;
            Departments.AllowUserToDeleteRows = false;
            Departments.BackgroundColor = Color.Black;
            Departments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Departments.Location = new Point(12, 92);
            Departments.Name = "Departments";
            Departments.ReadOnly = true;
            Departments.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Departments.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            Departments.RowTemplate.DefaultCellStyle.Format = "N3";
            Departments.RowTemplate.DefaultCellStyle.NullValue = null;
            Departments.Size = new Size(806, 377);
            Departments.TabIndex = 74;
            // 
            // ShowAllDepartments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(830, 481);
            Controls.Add(BackButton);
            Controls.Add(label1);
            Controls.Add(Departments);
            ForeColor = Color.White;
            Name = "ShowAllDepartments";
            Text = "ShowAllDepartments";
            FormClosed += ShowAllDepartments_FormClosed;
            Load += ShowAllDepartments_Load;
            ((System.ComponentModel.ISupportInitialize)Departments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label label1;
        private DataGridView Departments;
    }
}