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
    public partial class ShowAllStudents : Form
    {
        public ShowAllStudents()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ShowAllStudents_Load(object sender, EventArgs e)
        {
            EntryYear.Items.Add("All");
            Major.Items.Add("All");
            Course.Items.Add("All");

            string parametarizedQuery = "SELECT entry_year FROM " + "Student ";

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    EntryYear.Items.Add(reader.GetInt32(0));
                }
            }


            parametarizedQuery = "SELECT department_id FROM " + "Department ";

            sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Major.Items.Add(reader[0]);
                }
            }

            parametarizedQuery = "SELECT course_id FROM " + "Course ";

            sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Course.Items.Add(reader[0]);
                }
            }


        }


        private void ShowButton_Click(object sender, EventArgs e)
        {
                bool department_id_bool = false;
                bool year_bool = false;
                
                if (Major.Text != "" && Major.Text != "All")
                {
                    department_id_bool = true;
                }
                if (EntryYear.Text != "" && EntryYear.Text != "All")
                {
                    year_bool = true;
                }

                string parametarizedQuery = "SELECT * FROM " + "accounts, Student " +
                                            " where accounts.account_id = Student.account_id";

                if (department_id_bool)
                {
                    parametarizedQuery += " and department_id = " + Major.Text;

                }

                if (year_bool)
                {
                    parametarizedQuery += " and entry_year = " + EntryYear.Text;

                }

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();

                dataAdapter.Fill(dataTable);
                Students.DataSource = dataTable;
        }

        private void ShowAllStudents_close(object sender, FormClosedEventArgs e)
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
