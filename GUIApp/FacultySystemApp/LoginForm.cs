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
using static System.Windows.Forms.DataFormats;

namespace FacultySystemApp
{
    public partial class LoginForm : Form
    {
        //public event EventHandler verified;
        public event EventHandler<UserTypeEventArgs> LoginSuccess;

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = EmailInput.Text;
            string password = PasswordInput.Text;


            string check_query = $"SELECT role,account_id FROM accounts WHERE email = '{email}' AND password='{password}'";
            SqlCommand sc = new SqlCommand(check_query, DatabaseManager.Connection);

            using (SqlDataReader reader = sc.ExecuteReader())
            {
                if (reader.Read())
                {
                    LoginSuccess?.Invoke(this, new UserTypeEventArgs("" + reader[0], "" + reader[1]));
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Replace these with your actual user validation logic
            //if (email == "a" && password == "a")
            //{
            //    LoginSuccess?.Invoke(this, new UserTypeEventArgs("admin", email , password));
            //    this.Hide();
            //}
            //else if (email == "s" && password == "s")
            //{
            //    LoginSuccess?.Invoke(this, new UserTypeEventArgs("student", email, password));
            //    this.Hide();
            //}
            //else
            //{
            //}
        }
    }
}

public class UserTypeEventArgs : EventArgs
{
    public string UserType { get; }
    public string ID { get; }

    public UserTypeEventArgs(string userType, string id)
    {
        UserType = userType;
        ID = id;
    }
}
