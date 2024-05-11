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
            loginEmailInput = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            LoginUserButton = new Button();
            SuspendLayout();
            // 
            // loginlabel
            // 
            loginlabel.AutoSize = true;
            loginlabel.Font = new Font("Segoe UI", 30F);
            loginlabel.ForeColor = Color.White;
            loginlabel.Location = new Point(446, 80);
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
            loginEmailLabel.Location = new Point(285, 358);
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
            loginPasswordLabel.Location = new Point(214, 506);
            loginPasswordLabel.Name = "loginPasswordLabel";
            loginPasswordLabel.Size = new Size(188, 54);
            loginPasswordLabel.TabIndex = 3;
            loginPasswordLabel.Text = "Password";
            // 
            // loginEmailInput
            // 
            loginEmailInput.Font = new Font("Segoe UI", 15F);
            loginEmailInput.Location = new Point(466, 358);
            loginEmailInput.Name = "loginEmailInput";
            loginEmailInput.Size = new Size(372, 34);
            loginEmailInput.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(466, 519);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 34);
            textBox1.TabIndex = 5;
            // 
            // LoginUserButton
            // 
            LoginUserButton.FlatStyle = FlatStyle.System;
            LoginUserButton.Font = new Font("Segoe UI", 20F);
            LoginUserButton.Location = new Point(568, 638);
            LoginUserButton.Name = "LoginUserButton";
            LoginUserButton.Size = new Size(165, 65);
            LoginUserButton.TabIndex = 6;
            LoginUserButton.Text = "Login";
            LoginUserButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1334, 761);
            Controls.Add(LoginUserButton);
            Controls.Add(textBox1);
            Controls.Add(loginEmailInput);
            Controls.Add(loginPasswordLabel);
            Controls.Add(loginEmailLabel);
            Controls.Add(loginlabel);
            ForeColor = Color.White;
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginlabel;
        private Label loginEmailLabel;
        private Label loginPasswordLabel;
        private TextBox loginEmailInput;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private Button LoginUserButton;
    }
}
