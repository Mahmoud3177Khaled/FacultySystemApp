using FacultySystemApp.admin.admins;
using FacultySystemApp.admin.staff;
using FacultySystemApp.admin.students;
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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SignupStudent_Click(object sender, EventArgs e)
        {
            SignupStudent signupStudent = new SignupStudent();
            signupStudent.Show();
            this.Hide();
        }
        private void ShowStudent_Click(object sender, EventArgs e)
        {
            ShowStudent showStudent = new ShowStudent();
            showStudent.Show();
            this.Hide();
        }

        private void ShowAllStudents_Click(object sender, EventArgs e)
        {
            ShowAllStudents showAllStudents = new ShowAllStudents();
            showAllStudents.Show();
            this.Hide();
        }

        private void AddStuff_Click(object sender, EventArgs e)
        {
            AddStuff addStuff = new AddStuff();
            addStuff.Show();
            this.Hide();
        }

        private void ShowStaff_Click(object sender, EventArgs e)
        {
            ShowStaff showStaff = new ShowStaff();
            showStaff.Show();
            this.Hide();
        }

        private void ShowAllStaff_Click(object sender, EventArgs e)
        {
            ShowAllStaff showAllStaff = new ShowAllStaff();
            showAllStaff.Show();
            this.Hide();
        }

        private void SignupAdmin_Click(object sender, EventArgs e)
        {
            SignupAdmin signupAdmin = new SignupAdmin();
            signupAdmin.Show();
            this.Hide();
        }

        private void ShowAdmin_Click(object sender, EventArgs e)
        {
            ShowAdmin showAdmin = new ShowAdmin();
            showAdmin.Show();
            this.Hide();
        }

        private void ShowAllAdmins_Click(object sender, EventArgs e)
        {
            ShowAllAdmins showAllAdmins = new ShowAllAdmins();
            showAllAdmins.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Hide();
        }
        private void ManageUsers_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
