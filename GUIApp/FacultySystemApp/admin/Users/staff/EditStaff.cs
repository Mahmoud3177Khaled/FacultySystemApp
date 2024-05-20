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
    public partial class EditStaff : Form
    {
        private string StaffID;

        public EditStaff(string StaffID)
        {
            InitializeComponent();
            CenterToScreen();
            this.StaffID = StaffID;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ShowStaff showStaff = new ShowStaff(StaffID);
            showStaff.Show();
            this.Hide();
        }

        private void EditStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string parametarizedQuery = "update " + "Staff  ";
            parametarizedQuery += " set staff_first_name = @staff_first_name," +
                                 " staff_middle_name = @staff_middle_name, staff_last_name = @staff_last_name";
            parametarizedQuery += " where staff_id = " + StaffID;
            // department_id = @department_id,

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);

            //sqlCommand.Parameters.AddWithValue("@department_id", department_id);
            sqlCommand.Parameters.AddWithValue("@staff_first_name", firstName.Text);
            sqlCommand.Parameters.AddWithValue("@staff_middle_name", middleName.Text);
            sqlCommand.Parameters.AddWithValue("@staff_last_name",lastName.Text);
            sqlCommand.ExecuteNonQuery();

        }

        private void EditStaff_Load(object sender, EventArgs e)
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
    }
}
