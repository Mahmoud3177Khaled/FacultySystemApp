namespace FacultySystemApp
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            loginlabel = new Label();
            loginEmailLabel = new Label();
            loginPasswordLabel = new Label();
            EmailInput = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            PasswordInput = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // loginlabel
            // 
            loginlabel.AutoSize = true;
            loginlabel.Font = new Font("Segoe UI", 30F);
            loginlabel.ForeColor = Color.White;
            loginlabel.Location = new Point(264, 78);
            loginlabel.Name = "loginlabel";
            loginlabel.Size = new Size(416, 54);
            loginlabel.TabIndex = 1;
            loginlabel.Text = "Login to your Account";
            // 
            // loginEmailLabel
            // 
            loginEmailLabel.AutoSize = true;
            loginEmailLabel.Font = new Font("Segoe UI", 30F);
            loginEmailLabel.ForeColor = Color.White;
            loginEmailLabel.Location = new Point(166, 210);
            loginEmailLabel.Name = "loginEmailLabel";
            loginEmailLabel.Size = new Size(117, 54);
            loginEmailLabel.TabIndex = 2;
            loginEmailLabel.Text = "Email";
            // 
            // loginPasswordLabel
            // 
            loginPasswordLabel.AutoSize = true;
            loginPasswordLabel.Font = new Font("Segoe UI", 30F);
            loginPasswordLabel.ForeColor = Color.White;
            loginPasswordLabel.Location = new Point(95, 342);
            loginPasswordLabel.Name = "loginPasswordLabel";
            loginPasswordLabel.Size = new Size(188, 54);
            loginPasswordLabel.TabIndex = 3;
            loginPasswordLabel.Text = "Password";
            // 
            // EmailInput
            // 
            EmailInput.Font = new Font("Segoe UI", 15F);
            EmailInput.Location = new Point(347, 210);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(372, 34);
            EmailInput.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // PasswordInput
            // 
            PasswordInput.Font = new Font("Segoe UI", 15F);
            PasswordInput.Location = new Point(347, 355);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(372, 34);
            PasswordInput.TabIndex = 5;
            // 
            // LoginButton
            // 
            LoginButton.FlatStyle = FlatStyle.System;
            LoginButton.Font = new Font("Segoe UI", 20F);
            LoginButton.Location = new Point(421, 482);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(131, 52);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(971, 656);
            Controls.Add(LoginButton);
            Controls.Add(PasswordInput);
            Controls.Add(EmailInput);
            Controls.Add(loginPasswordLabel);
            Controls.Add(loginEmailLabel);
            Controls.Add(loginlabel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginlabel;
        private Label loginEmailLabel;
        private Label loginPasswordLabel;
        private TextBox EmailInput;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox PasswordInput;
        private Button LoginButton;
    }
}
