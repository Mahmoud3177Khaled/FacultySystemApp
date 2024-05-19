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
    public partial class ShowAllDepartments : Form
    {
        public ShowAllDepartments()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ShowAllDepartments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageDepartments manageDepartments = new ManageDepartments();
            manageDepartments.Show();
            this.Hide();
        }

        private void ShowAllDepartments_Load(object sender, EventArgs e)
        {
            List<string> strings = new List<string>
                {
                "gg",
                "cc",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "mm"
            };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StudentName", typeof(string));

            foreach (string name in strings)
            {
                dataTable.Rows.Add(name);
            }

            Departments.DataSource = dataTable;
        }
    }
}
