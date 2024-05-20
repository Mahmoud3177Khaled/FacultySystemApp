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

namespace FacultySystemApp.admin.staff
{
    public partial class AddStuff : Form
    {
        public AddStuff()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();
        }

        private void AddStuff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {

            string parametarizedQuery = "INSERT INTO " + "Staff ";

            parametarizedQuery += " VALUES(@staff_id, @department_id, @staff_first_name," +
                                  " @staff_middle_name, @staff_last_name);";

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);

            sqlCommand.Parameters.AddWithValue("@staff_id", id.Text);
            sqlCommand.Parameters.AddWithValue("@department_id", DepartmentID.Text);
            sqlCommand.Parameters.AddWithValue("@staff_first_name", firstName.Text);
            sqlCommand.Parameters.AddWithValue("@staff_middle_name", middleName.Text);
            sqlCommand.Parameters.AddWithValue("@staff_last_name", lastName.Text);
            sqlCommand.ExecuteNonQuery();

        }

        private void AddStuff_Load(object sender, EventArgs e)
        {

        }
    }
}
