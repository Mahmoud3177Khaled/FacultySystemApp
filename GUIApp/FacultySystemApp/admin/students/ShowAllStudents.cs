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
    public partial class ShowAllStudents : Form
    {
        public ShowAllStudents()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ShowAllStudents_Load(object sender, EventArgs e)
        {
            GraduationYear.Items.Add(2020);
            GraduationYear.Items.Add(2021);
            GraduationYear.Items.Add(2022);
            GraduationYear.Items.Add(2023);

            Major.Items.Add("CS");
            Course.Items.Add("OOP");


        }


        private void ShowButton_Click(object sender, EventArgs e)
        {
            List<string> strings = new List<string>
                {
                "gg",
                "cc",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "bb",
                "mm"
            };

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("StudentName", typeof(string));

            foreach (string name in strings)
            {
                dataTable.Rows.Add(name);
            }

            Students.DataSource = dataTable;
        }
        
        private void ShowAllStudents_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
