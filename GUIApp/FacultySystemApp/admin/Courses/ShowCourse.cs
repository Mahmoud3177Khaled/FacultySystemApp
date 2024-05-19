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
    }
}
