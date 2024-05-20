using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystemApp.admin.admins
{
    public partial class ShowAdmin : Form
    {
        private string AdminID;

        public ShowAdmin(string userId)
        {
            InitializeComponent();
            CenterToScreen();
            this.AdminID = userId;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditAdmin editAdmin = new EditAdmin(AdminID);
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

        private void ShowAdmin_Load(object sender, EventArgs e)
        {
            AdminIdLabel.Text = "Admin: " + this.AdminID;

            string parametarizedQuery = "SELECT * FROM " + "accounts, Admin " +
                                 " where accounts.account_id = Admin.account_id" +
                                 " and admin_id = " + AdminID;

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                reader.Read();
                id.Text = reader[5].ToString();
                username.Text = reader[1].ToString();
                Password.Text = reader[2].ToString();
                Email.Text = reader[3].ToString();
                firstName.Text = reader[7].ToString();
                middleName.Text = reader[8].ToString();
                lastName.Text = reader[9].ToString();
                Address.Text = reader[10].ToString();

            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

            string preprequery = $"select account_id from Admin where admin_id = {AdminID}";
            SqlCommand preprecommand = new SqlCommand(preprequery, DatabaseManager.Connection);
            int account_id = Convert.ToInt32(preprecommand.ExecuteScalar());
            //Console.WriteLine("--" + account_id + "--");

            string parametarizedQuery = "DELETE FROM " + "Admin " +
                                        " where admin_id = " + AdminID;

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);
            sqlCommand.ExecuteNonQuery();

            string prequery = "DELETE FROM accounts " +
                             $" where account_id = {account_id}";

            SqlCommand precommand = new SqlCommand(prequery, DatabaseManager.Connection);
            precommand.ExecuteNonQuery();

        }
    }
}
