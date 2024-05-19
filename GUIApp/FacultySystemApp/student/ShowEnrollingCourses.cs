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
    public partial class ShowEnrollingCourses : Form
    {
        public ShowEnrollingCourses()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StudentPage studentPage = new StudentPage();
            studentPage.Show();
            this.Hide();
        }

        private void ShowEnrollingCourses_Load(object sender, EventArgs e)
        {

        }

        private void ShowEnrollingCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
