
using Microsoft.VisualBasic.Logging;
using FacultySystemApp.student;
using FacultySystemApp.admin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FacultySystemApp
{
    public partial class WelcomeForm : Form
    {
        Form page;

        public WelcomeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.LoginSuccess += login_LoginSuccess;
            login.Show();
            //this.Hide();
        }

        private void login_LoginSuccess(object sender, UserTypeEventArgs e)
        {
            //this.Hide();
            this.Hide();
            UserSession.Email = e.Email;
            UserSession.Password = e.Password;
            if (e.UserType == "admin")
            {
                page = new AdminPage();
            }
            else if (e.UserType == "student")
            {
                page = new StudentPage();
            }
            page.Show();
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
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();
        }

        private void WelcomeFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
