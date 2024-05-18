﻿using System;
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
    public partial class ShowAdmin : Form
    {
        public ShowAdmin()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditAdmin editAdmin = new EditAdmin();
            editAdmin.Show();
            this.Hide();
        }

        private void ShowAdmin_close(object sender, FormClosedEventArgs e)
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