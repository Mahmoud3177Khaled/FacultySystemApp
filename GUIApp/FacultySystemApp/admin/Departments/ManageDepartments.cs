using FacultySystemApp.admin.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin.Departments
{
    public partial class ManageDepartments : Form
    {
        public ManageDepartments()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ManageDepartments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Hide();
        }

        private void AddDepartmentButton_Click(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment();
            addDepartment.Show();
            this.Hide();
        }

        private void ShowDepartmentButton_Click(object sender, EventArgs e)
        {
            List<string> DepartmentIDs = new List<string>
                {
                "Department",
                "Department",
                "Department"
                };
            DepartmentIDInputForm idInputForm = new DepartmentIDInputForm(DepartmentIDs);
            if (idInputForm.ShowDialog() == DialogResult.OK)
            {
                string DepartmentID = idInputForm.DepartmentID;
                ShowDepartment showDepartment = new ShowDepartment(DepartmentID);
                showDepartment.Show();
                this.Hide();
            }
        }

        private void ShowAllDepartmentsButton_Click(object sender, EventArgs e)
        {
            ShowAllDepartments showAllDepartments = new ShowAllDepartments();
            showAllDepartments.Show();
            this.Hide();
        }
    }
}
