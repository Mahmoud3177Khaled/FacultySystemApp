
using Microsoft.VisualBasic.Logging;

namespace FacultySystemApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you an Admin?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                VerifyAdmin verifyAdmin = new VerifyAdmin();
                verifyAdmin.verified += verifyAdmin_verify;
                verifyAdmin.Show();
            }
        }

        private void verifyAdmin_verify(object sender, EventArgs e)
        {
            //this.Hide();
            this.Hide();
            SignupForm signup = new SignupForm();
            //userForm.Show();
            signup.Show();
        }

        private void WelcomeFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
