using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin.staff
{
    public partial class EditStaff : Form
    {
        public EditStaff()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ShowStaff showStaff = new ShowStaff("g");
            showStaff.Show();
            this.Hide();
        }

        private void EditStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
