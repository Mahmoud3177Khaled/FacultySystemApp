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

namespace FacultySystemApp
{
    public partial class VerifyAdmin : Form
    {
        public event EventHandler<UserTypeEventArgs> verified;

        public VerifyAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string email = Email.Text;
            string password = Password.Text;

            string check_query = $"SELECT role,account_id FROM accounts WHERE email = '{email}' AND password='{password}'";
            SqlCommand sc = new SqlCommand(check_query, DatabaseManager.Connection);

            using (SqlDataReader reader = sc.ExecuteReader())
            {
                if (reader.Read() && (("" + reader[0]) != "admin"))
                {
                    verified?.Invoke(this, new UserTypeEventArgs("" + reader[0], "" + reader[1]));
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //if (email == "a" && password == "a")
            //{
            //    verified?.Invoke(this, EventArgs.Empty);
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
