﻿using System;
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
    public partial class EditCourse : Form
    {
        public EditCourse()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ShowCourse showCourse = new ShowCourse("g");
            showCourse.Show();
            this.Hide();
        }

        private void EditCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SaveCourseButton_Click(object sender, EventArgs e)
        {

        }
    }
}