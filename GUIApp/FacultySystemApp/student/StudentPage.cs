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
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadProfile(UserSession.ID);
        }

        private void LoadProfile(string ID)
        {
            // Load user profile using email and password

        }

        private void StudentPageClosed(object sender, FormClosedEventArgs e)

        {
            Application.Exit();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditStudentProfile editStudentProfile = new EditStudentProfile();
            editStudentProfile.Show();
            this.Hide();
        }

        private void ShowEnrollingCourses_Click(object sender, EventArgs e)
        {
            ShowEnrollingCourses showEnrollingCourses = new ShowEnrollingCourses();
            showEnrollingCourses.Show();
            this.Hide();
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {

        }
    }
}
