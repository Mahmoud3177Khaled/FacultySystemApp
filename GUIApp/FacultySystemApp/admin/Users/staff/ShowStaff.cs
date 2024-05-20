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
    public partial class ShowStaff : Form
    {
        private string StaffID;

        public ShowStaff(string userId)
        {
            InitializeComponent();
            CenterToScreen();
            this.StaffID = userId;
        }

        private void ShowStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditStaff editStaff = new EditStaff(StaffID);
            editStaff.Show();
            this.Hide();
        }

        private void ShowStaff_Load(object sender, EventArgs e)
        {
            StaffIdLabel.Text = "Staff : " + this.StaffID;

            string parametarizedQuery = "SELECT * FROM " + "Staff " +
                            //" where accounts.account_id = Student.account_id" +
                            " where staff_id = " + StaffID;

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);
            //Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student deleted.\n");

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    id.Text = reader[0].ToString();
                    departmentID.Text = reader[1].ToString();
                    firstName.Text = reader[2].ToString();
                    middleName.Text = reader[3].ToString();
                    lastName.Text = reader[4].ToString();
                }

            }

        }

        private void Remove_Click(object sender, EventArgs e)
        {

            string prequery = "DELETE FROM Staff  " +
                             $" where staff_id = {StaffID}";

            SqlCommand precommand = new SqlCommand(prequery, DatabaseManager.Connection);
            precommand.ExecuteNonQuery();
        }
    }
}
