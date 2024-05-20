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
    public partial class SignupStudent : Form
    {
        public SignupStudent()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void AddStudent_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string prequery = "INSERT INTO accounts " +
                  " VALUES('" + username.Text + "', '" + password.Text + "', '" + email.Text + "', '" + "student" + "');";

            SqlCommand precommand = new SqlCommand(prequery, DatabaseManager.Connection);
            precommand.ExecuteNonQuery();
            SqlCommand idcommand = new SqlCommand(" SELECT SCOPE_IDENTITY();", DatabaseManager.Connection);
            int account_id;
            account_id = Convert.ToInt32(idcommand.ExecuteScalar());
            string parametarizedQuery = "INSERT INTO " + "Student ";

            parametarizedQuery += " VALUES(@student_id, @department_id, @account_id, @student_first_name," +
                                  " @student_middle_name, @student_last_name, @entry_year, @student_address);";

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);

            sqlCommand.Parameters.AddWithValue("@student_id", id.Text);
            sqlCommand.Parameters.AddWithValue("@department_id", departmentID.Text);
            sqlCommand.Parameters.AddWithValue("@account_id", account_id);
            sqlCommand.Parameters.AddWithValue("@student_first_name", firstName.Text);
            sqlCommand.Parameters.AddWithValue("@student_middle_name", middleName.Text);
            sqlCommand.Parameters.AddWithValue("@student_last_name", lastName.Text);
            sqlCommand.Parameters.AddWithValue("@entry_year", DateTime.Now.Year);
            sqlCommand.Parameters.AddWithValue("@student_address", address.Text);
            sqlCommand.ExecuteNonQuery();
        }

        private void SignupStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
