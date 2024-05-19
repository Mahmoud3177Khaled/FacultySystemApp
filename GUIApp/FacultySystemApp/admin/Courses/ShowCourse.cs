using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin.Courses
{
    public partial class ShowCourse : Form
    {
        private String CourseID;
        public ShowCourse(String CourseID)
        {
            InitializeComponent();
            CenterToScreen();
            this.CourseID = CourseID;
        }

        private void ShowCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageCourses manageCourses = new ManageCourses();
            manageCourses.Show();
            this.Hide();
        }

        private void EditCourseButton_Click(object sender, EventArgs e)
        {
            EditCourse editCourse = new EditCourse();
            editCourse.Show();
            this.Hide();
        }

        private void ShowCourse_Load(object sender, EventArgs e)
        {
            CourseIDLabel.Text = "Course : " + CourseID;
        }

        private void EnrollStudentButton_Click(object sender, EventArgs e)
        {
            List<string> StudentIDs = new List<string>
                {
                "Student",
                "Student",
                "Student"
                };
            UserIDInputForm idInputForm = new UserIDInputForm("Student", StudentIDs);
            if (idInputForm.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Enroll " + idInputForm.UserID +" to Course " + CourseID + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("The student enrolled successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string userId = idInputForm.UserID;

                    ////////////function////////////////
                }
                
            }
        }
    }
}
