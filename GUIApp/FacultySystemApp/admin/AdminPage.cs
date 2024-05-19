using FacultySystemApp.admin.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void AdminPageClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            WelcomeForm welcome = new WelcomeForm();
            welcome.Show();
            this.Hide();
        }

        private void ManageUsersButton_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();
        }

        private void ManageCoursesButton_Click(object sender, EventArgs e)
        {
            ManageCourses manageCourses = new ManageCourses();
            manageCourses.Show();
            this.Hide();

        }

        private void ManageDepartmentsButton_Click(object sender, EventArgs e)
        {
            ManageDepartments manageDepartment = new ManageDepartments();
            manageDepartment.Show();
            this.Hide();
        }
    }
}
