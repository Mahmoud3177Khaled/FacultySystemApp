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
    public partial class ShowAllStaff : Form
    {
        public ShowAllStaff()
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

        private void ShowAllStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShowAllStaff_Load(object sender, EventArgs e)
        {

            string parametarizedQuery = "SELECT * FROM " + "Staff ";

            SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, DatabaseManager.Connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            Staff.DataSource = dataTable;

            //int count = 1;
            //using (SqlDataReader reader = sqlCommand.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("--------------------------------------");
            //        Console.WriteLine("Staff member #" + count + ":");
            //        Console.WriteLine();
            //        Console.WriteLine("staff_id: .............. " + reader[0]);
            //        Console.WriteLine("department_id: ......... " + reader[1]);
            //        Console.WriteLine("staff_first_name: ...... " + reader[2]);
            //        Console.WriteLine("staff_middle_name: ..... " + reader[3]);
            //        Console.WriteLine("staff_last_name: ....... " + reader[4]);
            //        Console.WriteLine("--------------------------------------");
            //        count++;
            //    }

            //}


            //List<string> strings = new List<string>
            //    {
            //    "gg",
            //    "cc",
            //    "bb",
            //    "bb",
            //    "bb",
            //    "bb",
            //    "bb",
            //    "bb",
            //    "bb",
            //    "bb",
            //    "bb",
            //    "bb",
            //    "mm"
            //};

            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("StudentName", typeof(string));

            //foreach (string name in strings)
            //{
            //    dataTable.Rows.Add(name);
            //}

            //Staff.DataSource = dataTable;
        }

        private void Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
