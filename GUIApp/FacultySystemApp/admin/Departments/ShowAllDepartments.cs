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

    }
}
