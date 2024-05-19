using FacultySystemApp.admin.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin
{
    public partial class ManageCourses : Form
    {
        public ManageCourses()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ManageCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CreateCourseButton_Click(object sender, EventArgs e)
        {
            CreateCourse createCourse = new CreateCourse();
            createCourse.Show();
            this.Hide();
        }

        private void ShowCourseButton_Click(object sender, EventArgs e)
        {
            List<string> CourseIDs = new List<string>
                {
                "Course",
                "Course",
                "Course"
                };
            CourseIDInputForm idInputForm = new CourseIDInputForm(CourseIDs);
            if (idInputForm.ShowDialog() == DialogResult.OK)
            {
                string CourseID = idInputForm.CourseID;
                ShowCourse showCourse = new ShowCourse(CourseID);
                showCourse.Show();
                this.Hide();
            }
        }

        private void ShowAllCoursesButton_Click(object sender, EventArgs e)
        {
            ShowAllCourses showAllCourses = new ShowAllCourses();
            showAllCourses.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Hide();
        }
    }
}
