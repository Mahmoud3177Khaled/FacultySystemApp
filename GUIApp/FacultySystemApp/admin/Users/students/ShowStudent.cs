using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin.students
{
    public partial class ShowStudent : Form
    {
        private string StudentID;

        public ShowStudent(string userId)
        {
            InitializeComponent();
            CenterToScreen();
            this.StudentID = userId;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent(StudentID);
            editStudent.Show();
            this.Hide();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string preprequery = $"select account_id from Student where student_id = {id.Text}";
            SqlCommand preprecommand = new SqlCommand(preprequery, DatabaseManager.Connection);
            int account_id = Convert.ToInt32(preprecommand.ExecuteScalar());


            string parametarizedQuery = "DELETE FROM " + "Student " +
                                        " where student_id = " + id.Text;

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);
            sqlCommand.ExecuteNonQuery();


            string prequery = "DELETE FROM accounts " +
                             $" where account_id = {account_id}";

            SqlCommand precommand = new SqlCommand(prequery, DatabaseManager.Connection);
            sqlCommand.ExecuteNonQuery();


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

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            StudentIdLabel.Text = "Student : " + StudentID;

            string parametarizedQuery = "SELECT * FROM " + "accounts, Student " +
                                        " where accounts.account_id = Student.account_id" +
                                        " and student_id = " + StudentID;

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if (reader.Read())
                {

                    username.Text = reader[1].ToString();
                    Password.Text = reader[2].ToString();
                    Email.Text = reader[3].ToString();
                    id.Text = reader[5].ToString();
                    DepartmentID.Text = reader[6].ToString();
                    firstName.Text = reader[8].ToString();
                    middleName.Text = reader[9].ToString();
                    lastName.Text = reader[10].ToString();
                    EntryYear.Text = reader[11].ToString();
                    Address.Text = reader[12].ToString();
                }
            }
        }
    }
}
