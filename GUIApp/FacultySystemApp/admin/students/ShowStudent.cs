﻿using System;
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
    public partial class ShowStudent : Form
    {
        public ShowStudent()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            editStudent.Show();
            this.Hide();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void ShowStudent_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();
        }
    }
}