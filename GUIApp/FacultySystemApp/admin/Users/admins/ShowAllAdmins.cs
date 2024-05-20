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

namespace FacultySystemApp.admin.admins
{
    public partial class ShowAllAdmins : Form
    {
        public ShowAllAdmins()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void ShowAllAdmins_Load(object sender, EventArgs e)
        {


            string parametarizedQuery = "SELECT * FROM " + "accounts, Admin " +
                                        " where accounts.account_id = Admin.account_id";

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);


            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            Admins.DataSource = dataTable;
        }

        private void ShowAllAdmins_FormClosed(object sender, FormClosedEventArgs e)
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
