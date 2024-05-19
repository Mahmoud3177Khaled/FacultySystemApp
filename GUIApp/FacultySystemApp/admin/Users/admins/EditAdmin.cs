using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin.admins
{
    public partial class EditAdmin : Form
    {
        public EditAdmin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void EditAdmin_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ShowAdmin showAdmin = new ShowAdmin("g");
            showAdmin.Show();
            this.Hide();
        }
    }
}
