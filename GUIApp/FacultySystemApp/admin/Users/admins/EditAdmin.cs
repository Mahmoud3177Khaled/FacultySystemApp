using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EditAdmin : Form
    {
        private string AdminID;

        public EditAdmin(string AdminID)
        {
            InitializeComponent();
            CenterToScreen();
            this.AdminID = AdminID;
        }

        private void EditAdmin_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string preprequery = $"select account_id from Admin where admin_id = {AdminID}";
            SqlCommand preprecommand = new SqlCommand(preprequery, DatabaseManager.Connection);
            int account_id = Convert.ToInt32(preprecommand.ExecuteScalar());
            //Console.WriteLine("--" + account_id + "--");

            string prequery = "update accounts " +
                              $" set  user_name = '{username.Text}',  password = '{Password.Text}',  email = '{Email.Text}', role = 'admin'" +
                              $" where account_id = {account_id}";

            SqlCommand precommand = new SqlCommand(prequery, DatabaseManager.Connection);
            precommand.ExecuteNonQuery();

            string parametarizedQuery = "update " + "Admin  ";
            parametarizedQuery += " set admin_first_name = @admin_first_name," +
                                 " admin_middle_name = @admin_middle_name, admin_last_name = @admin_last_name, admin_address = @admin_address";
            parametarizedQuery += " where admin_id = " + AdminID;

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);


            sqlCommand.Parameters.AddWithValue("@admin_first_name", firstName.Text);
            sqlCommand.Parameters.AddWithValue("@admin_middle_name", middleName.Text);
            sqlCommand.Parameters.AddWithValue("@admin_last_name", lastName.Text);
            sqlCommand.Parameters.AddWithValue("@admin_address", Address.Text);
            sqlCommand.ExecuteNonQuery();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ShowAdmin showAdmin = new ShowAdmin(AdminID);
            showAdmin.Show();
            this.Hide();
        }

        private void EditAdmin_Load(object sender, EventArgs e)
        {
            AdminIdLabel.Text = "Edit Admin : " + AdminID;

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
    }
}
