namespace FacultySystemApp.admin.staff
{
    partial class ShowAllStaff
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
            Staff = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Staff).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(48, 11);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 73;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(415, 11);
            label1.Name = "label1";
            label1.Size = new Size(135, 46);
            label1.TabIndex = 72;
            label1.Text = "All Staff";
            // 
            // Staff
            // 
            Staff.AllowUserToAddRows = false;
            Staff.AllowUserToDeleteRows = false;
            Staff.BackgroundColor = Color.Black;
            Staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Staff.Location = new Point(13, 84);
            Staff.Name = "Staff";
            Staff.ReadOnly = true;
            Staff.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Staff.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            Staff.RowTemplate.DefaultCellStyle.Format = "N2";
            Staff.RowTemplate.DefaultCellStyle.NullValue = null;
            Staff.Size = new Size(983, 509);
            Staff.TabIndex = 71;
            Staff.CellContentClick += Staff_CellContentClick;
            // 
            // ShowAllStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1008, 604);
            Controls.Add(BackButton);
            Controls.Add(label1);
            Controls.Add(Staff);
            ForeColor = Color.White;
            Name = "ShowAllStaff";
            Text = "ShowAllStaff";
            FormClosed += ShowAllStaff_FormClosed;
            Load += ShowAllStaff_Load;
            ((System.ComponentModel.ISupportInitialize)Staff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Label label1;
        private DataGridView Staff;
    }
}