namespace FacultySystemApp
{
    partial class WelcomeForm 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcome = new Label();
            madeBy = new Label();
            LoginButton = new Button();
            SignupButton = new Button();
            hScrollBar1 = new HScrollBar();
            smile = new Label();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Font = new Font("Segoe UI", 30F);
            welcome.ForeColor = Color.White;
            welcome.Location = new Point(382, 65);
            welcome.Name = "welcome";
            welcome.Size = new Size(588, 54);
            welcome.TabIndex = 0;
            welcome.Text = "Welcome to Faculty System App";
            // 
            // madeBy
            // 
            madeBy.AutoSize = true;
            madeBy.Font = new Font("Segoe UI", 25F);
            madeBy.ForeColor = Color.White;
            madeBy.Location = new Point(514, 167);
            madeBy.Name = "madeBy";
            madeBy.Size = new Size(284, 46);
            madeBy.TabIndex = 1;
            madeBy.Text = "Made by Team 87";
            // 
            // LoginButton
            // 
            LoginButton.FlatStyle = FlatStyle.System;
            LoginButton.Font = new Font("Segoe UI", 20F);
            LoginButton.Location = new Point(395, 337);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(139, 53);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // SignupButton
            // 
            SignupButton.FlatStyle = FlatStyle.System;
            SignupButton.Font = new Font("Segoe UI", 20F);
            SignupButton.Location = new Point(818, 337);
            SignupButton.Name = "SignupButton";
            SignupButton.Size = new Size(139, 53);
            SignupButton.TabIndex = 3;
            SignupButton.Text = "Signup";
            SignupButton.UseVisualStyleBackColor = true;
            SignupButton.Click += SignupButton_Click;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(663, 337);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(10, 190);
            hScrollBar1.TabIndex = 4;
            // 
            // smile
            // 
            smile.AutoSize = true;
            smile.BackColor = Color.Transparent;
            smile.Font = new Font("Segoe UI Black", 180F);
            smile.ForeColor = Color.White;
            smile.Location = new Point(505, 506);
            smile.Name = "smile";
            smile.Size = new Size(345, 318);
            smile.TabIndex = 5;
            smile.Text = "︶";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1334, 761);
            Controls.Add(hScrollBar1);
            Controls.Add(smile);
            Controls.Add(SignupButton);
            Controls.Add(LoginButton);
            Controls.Add(madeBy);
            Controls.Add(welcome);
            Name = "WelcomeForm";
            Text = "welcome";
            FormClosed += WelcomeFormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private Label madeBy;
        private Button LoginButton;
        private Button SignupButton;
        private HScrollBar hScrollBar1;
        private Label smile;
    }
}
