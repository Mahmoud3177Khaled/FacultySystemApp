using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin.admins
{
    public partial class ShowAdmin : Form
    {
        private string userId;

        public ShowAdmin(string userId)
        {
            InitializeComponent();
            CenterToScreen();
            this.userId = userId;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditAdmin editAdmin = new EditAdmin();
            editAdmin.Show();
            this.Hide();
        }

        private void ShowAdmin_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();
        }

        private void ShowAdmin_Load(object sender, EventArgs e)
        {
            AdminIdLabel.Text = "Admin: " + this.userId;
        }
    }
}
