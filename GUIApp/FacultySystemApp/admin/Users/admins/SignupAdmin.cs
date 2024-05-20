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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FacultySystemApp.admin.admins
{
    public partial class SignupAdmin : Form
    {
        public SignupAdmin()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void signupButton_Click(object sender, EventArgs e)
        {

            string prequery = "INSERT INTO accounts " +
                              " VALUES('" + username.Text + "', '" + Password.Text + "', '" + Email.Text + "', '" + "admin" + "');";

            SqlCommand precommand = new SqlCommand(prequery, DatabaseManager.Connection);

            precommand.ExecuteNonQuery();


            SqlCommand idcommand = new SqlCommand(" SELECT SCOPE_IDENTITY();", DatabaseManager.Connection);
            int account_id = Convert.ToInt32(idcommand.ExecuteScalar());

            string parametarizedQuery = "INSERT INTO " + "Admin  ";

            parametarizedQuery += " VALUES(@admin_id, @account_id, @admin_first_name," +
                                  " @admin_middle_name, @admin_last_name, @admin_address);";

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);

            sqlCommand.Parameters.AddWithValue("@admin_id", id.Text);
            sqlCommand.Parameters.AddWithValue("@account_id", account_id);
            sqlCommand.Parameters.AddWithValue("@admin_first_name", firstName.Text);
            sqlCommand.Parameters.AddWithValue("@admin_middle_name", middleName.Text);
            sqlCommand.Parameters.AddWithValue("@admin_last_name", lastName.Text);
            sqlCommand.Parameters.AddWithValue("@admin_address", Address.Text);
            sqlCommand.ExecuteNonQuery();

        }

        private void SignupAdmin_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();
        }

        private void SignupAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
