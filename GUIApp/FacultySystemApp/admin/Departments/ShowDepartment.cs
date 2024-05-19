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
    public partial class ShowDepartment : Form
    {
        private string DepartmentID;

        public ShowDepartment(string DepartmentID)
        {
            InitializeComponent();
            CenterToScreen();
            this.DepartmentID = DepartmentID;
        }

        private void ShowDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EditDepartmentButton_Click(object sender, EventArgs e)
        {
            EditDepartment editDepartment = new EditDepartment(DepartmentID);
            editDepartment.Show();
            this.Hide();
        }

        private void AssignStudentButton_Click(object sender, EventArgs e)
        {
            List<string> StudentIDs = new List<string>
                {
                "Student",
                "Student",
                "Student"
                };
            UserIDInputForm idInputForm = new UserIDInputForm("Student", StudentIDs);
            if (idInputForm.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Assign " + idInputForm.UserID + " to Department " + DepartmentID + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("The student Assigned successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string userId = idInputForm.UserID;

                    ////////////function////////////////
                }

            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageDepartments manageDepartments = new ManageDepartments();
            manageDepartments.Show();
            this.Hide();
        }

        private void ShowDepartment_Load(object sender, EventArgs e)
        {
            DepartmentLabel.Text = "Department : " + DepartmentID;
        }
    }
}
