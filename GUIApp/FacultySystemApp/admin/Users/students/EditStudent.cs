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
        private string StudentID;

        public EditStudent(string StudentID)
        {
            InitializeComponent();
            CenterToScreen();
            this.StudentID = StudentID;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void EditStudent_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ShowStudent showStudent = new ShowStudent(StudentID);
            showStudent.Show();
            this.Hide();
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
            StudentIdLabel.Text = "Edit Student : " + StudentID;
        }
    }
}
