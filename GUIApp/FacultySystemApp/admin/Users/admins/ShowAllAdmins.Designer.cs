namespace FacultySystemApp.admin.admins
{
    partial class ShowAllAdmins
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
            Admins = new DataGridView();
            label1 = new Label();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Admins).BeginInit();
            SuspendLayout();
            // 
            // Admins
            // 
            Admins.AllowUserToAddRows = false;
            Admins.AllowUserToDeleteRows = false;
            Admins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Admins.Location = new Point(12, 98);
            Admins.Name = "Admins";
            Admins.ReadOnly = true;
            Admins.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Admins.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            Admins.RowTemplate.DefaultCellStyle.Format = "N3";
            Admins.RowTemplate.DefaultCellStyle.NullValue = null;
            Admins.Size = new Size(983, 509);
            Admins.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(399, 24);
            label1.Name = "label1";
            label1.Size = new Size(179, 46);
            label1.TabIndex = 1;
            label1.Text = "All Admins";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Black;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 20F);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(12, 24);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(115, 47);
            BackButton.TabIndex = 70;
            BackButton.Text = "⇐ back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ShowAllAdmins
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1007, 619);
            Controls.Add(BackButton);
            Controls.Add(label1);
            Controls.Add(Admins);
            ForeColor = Color.White;
            Name = "ShowAllAdmins";
            Text = "ShowAllAdmins";
            FormClosed += ShowAllAdmins_FormClosed;
            Load += ShowAllAdmins_Load;
            ((System.ComponentModel.ISupportInitialize)Admins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Admins;
        private Label label1;
        private Button BackButton;
    }
}