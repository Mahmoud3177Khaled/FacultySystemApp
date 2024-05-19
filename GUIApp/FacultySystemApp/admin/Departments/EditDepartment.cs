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
    public partial class EditDepartment : Form
    {
        private string DepartmentID;

        public EditDepartment(string DepartmentID)
        {
            InitializeComponent();
            CenterToScreen();
            this.DepartmentID = DepartmentID;
        }

        private void EditDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ShowDepartment showDepartment = new ShowDepartment(DepartmentID);
            showDepartment.Show();
            this.Hide();
        }

        private void SaveDepartmentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
