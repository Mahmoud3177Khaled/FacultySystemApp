using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin.admins
{
    public partial class SignupAdmin : Form
    {
        public SignupAdmin()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void signupButton_Click(object sender, EventArgs e)
        {

        }

        private void SignupAdmin_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();
        }
    }
}
