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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            string preprequery = $"select account_id from Student where student_id = {StudentID}";
            SqlCommand preprecommand = new SqlCommand(preprequery, DatabaseManager.Connection);
            int account_id;
            account_id = Convert.ToInt32(preprecommand.ExecuteScalar());


            string prequery = "update accounts " +
                              $"set  user_name = '{username.Text}',  password = '{Password.Text}',  email = '{Email.Text}', role = 'student'" +
                              $" where account_id = {account_id}";


            SqlCommand precommand = new SqlCommand(prequery, DatabaseManager.Connection);
            precommand.ExecuteNonQuery(); 


            string parametarizedQuery = "update " + "Student ";
            parametarizedQuery += " set department_id = @department_id, student_first_name = @student_first_name," +
                                 " student_middle_name = @student_middle_name, student_last_name = @student_last_name, entry_year = @entry_year, student_address = @student_address";
            parametarizedQuery += " where student_id = " + StudentID;

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);


            sqlCommand.Parameters.AddWithValue("@department_id", departmentID.Text);
            sqlCommand.Parameters.AddWithValue("@student_first_name", firstName.Text);
            sqlCommand.Parameters.AddWithValue("@student_middle_name", middleName.Text);
            sqlCommand.Parameters.AddWithValue("@student_last_name", lastName.Text);
            sqlCommand.Parameters.AddWithValue("@entry_year", Int32.Parse(EntryYear.Text));
            sqlCommand.Parameters.AddWithValue("@student_address", Address.Text);
            sqlCommand.ExecuteNonQuery();
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
                    //id.Text = reader[5].ToString();
                    departmentID.Text = reader[6].ToString();
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
