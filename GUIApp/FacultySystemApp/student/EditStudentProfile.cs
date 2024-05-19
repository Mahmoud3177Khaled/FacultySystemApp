using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.student
{
    public partial class EditStudentProfile : Form
    {
        public EditStudentProfile()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void EditStudentProfile_Load(object sender, EventArgs e)
        {

        }

        private void EditStudentProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StudentPage studentPage = new StudentPage();
            studentPage.Show();
            this.Hide();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
