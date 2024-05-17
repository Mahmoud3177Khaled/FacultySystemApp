namespace FacultySystemApp
{
    partial class VerifyAdmin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Email = new TextBox();
            Password = new TextBox();
            Login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(249, 38);
            label1.Name = "label1";
            label1.Size = new Size(281, 37);
            label1.TabIndex = 0;
            label1.Text = "You must be an admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(122, 150);
            label2.Name = "label2";
            label2.Size = new Size(82, 37);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(76, 250);
            label3.Name = "label3";
            label3.Size = new Size(128, 37);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // Email
            // 
            Email.Font = new Font("Segoe UI", 15F);
            Email.Location = new Point(240, 150);
            Email.Name = "Email";
            Email.Size = new Size(382, 34);
            Email.TabIndex = 3;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 15F);
            Password.Location = new Point(240, 250);
            Password.Name = "Password";
            Password.Size = new Size(382, 34);
            Password.TabIndex = 4;
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 15F);
            Login.ForeColor = Color.Black;
            Login.Location = new Point(363, 347);
            Login.Name = "Login";
            Login.Size = new Size(99, 38);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // VerifyAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "VerifyAdmin";
            Text = "VerifyAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Email;
        private TextBox Password;
        private Button Login;
    }
}