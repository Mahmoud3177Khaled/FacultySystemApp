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
    public partial class ShowStaff : Form
    {
        private string userId;

        public ShowStaff(string userId)
        {
            InitializeComponent();
            CenterToScreen();
            this.userId = userId;
        }

        private void ShowStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditStaff editStaff = new EditStaff();
            editStaff.Show();
            this.Hide();
        }

        private void ShowStaff_Load(object sender, EventArgs e)
        {
            StaffIdLabel.Text = "Staff : " + this.userId;
        }
    }
}
