using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin.students
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
            CenterToScreen();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void EditStudent_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
