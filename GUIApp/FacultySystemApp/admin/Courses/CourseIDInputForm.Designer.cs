namespace FacultySystemApp.admin
{
    partial class CourseIDInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Button btnSubmit;
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
            label1 = new Label();
            btnSubmit = new Button();
            IDs = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter ID:";
            // 
            // btnSubmit
            // 
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(105, 68);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 31);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // IDs
            // 
            IDs.DropDownStyle = ComboBoxStyle.DropDownList;
            IDs.Font = new Font("Segoe UI", 12F);
            IDs.FormattingEnabled = true;
            IDs.Location = new Point(12, 33);
            IDs.Name = "IDs";
            IDs.Size = new Size(260, 29);
            IDs.TabIndex = 3;
            // 
            // CourseIDInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(284, 111);
            Controls.Add(IDs);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "CourseIDInputForm";
            Text = "Enter ID";
            Load += CourseIDInputForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox IDs;
    }
}
