using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace sqltest
{
    internal class DataBaseManipulator
    {
        public static SqlConnection sqlconn;

        public static String? table = "None";
        public static String? g_Database = "None";

        public static string user;
        public static string signedin_user_id;

        public static string singedin_type = "";
        public static int singedin_account_id;

        public static string email;
        public static string password;
        public static string username;
        public static string student_id;

        public static string admin_id;
        public static string first_name;
        public static string middle_name;
        public static string last_name;
        public static string admin_address;

        /*public static int pid;
        public static String? name;
        public static int price;
        public static String? category;

        public static String? month;

        public static String? cname;
        public static int cid;*/

        public static void OpenConnTo(String server = "localhost", String Database = "company", String security = "True")    // Establish DB connection
        {
            String connStr = $"Server= {server}; Database= {Database}; Integrated Security= {security};";

            try
            {
                sqlconn = new SqlConnection(connStr);

                Console.WriteLine("\n    Establishing connection... \n    . \n    . \n    .");
                sqlconn.Open();
                Console.WriteLine("    connection successful...\n\n");
                g_Database = Database;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }

        /*public static void ReadTable()
        {
            Console.WriteLine("Enter a Table to manipulate: ...");
            table = Console.ReadLine();

            if(table == "products" || table == "purchase" || table == "category")
            {
                Console.WriteLine("    Active table changed to --> " + table + "\n");
            }
            else
            {
                Console.WriteLine("\n\n    No table named " + table + "... Please select another table\n\n");
                table = "None";

            }

        }*/

        /*public static void ReadInput()
        {
            
            if(table == "products")
            {
                Console.WriteLine("Inserting a Product: ...");

                Console.WriteLine("PID: ");
                pid = int.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                name = Console.ReadLine();

                Console.WriteLine("Price: ");
                price = int.Parse(Console.ReadLine());

                Console.WriteLine("Category: ");
                category = Console.ReadLine();

            }
            else if (table == "purchase")
            {
                Console.WriteLine("Inserting a Purchase: ...");

                Console.WriteLine("PID: ");
                pid = int.Parse(Console.ReadLine());

                Console.WriteLine("Month: ");
                month = Console.ReadLine();

            }
            else if (table == "category")
            {
                Console.WriteLine("Inserting a Category: ...");

                Console.WriteLine("Category ID: ");
                cid = int.Parse(Console.ReadLine());

                Console.WriteLine("Category Name: ");
                cname = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("    Table does not exist...");
            }

        }*/

        /*public static void InsertRow()
        {
            string parametarizedQuery = "INSERT INTO " + table;

            SqlCommand? sqlCommand = null;

            if (table == "products")
            {
               parametarizedQuery += " VALUES(@pid, @name, @price, @category);";

                sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                //sqlCommand.Parameters.AddWithValue("@table", table);
                sqlCommand.Parameters.AddWithValue("@pid", pid);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@price", price);
                sqlCommand.Parameters.AddWithValue("@category", category);

            }
            else if(table == "purchase")
            {
                parametarizedQuery += " VALUES(@pid, @month);";

                sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                //sqlCommand.Parameters.AddWithValue("@table", table);
                sqlCommand.Parameters.AddWithValue("@pid", pid);
                sqlCommand.Parameters.AddWithValue("@month", month);

            }
            else if (table == "category")
            {
                parametarizedQuery += " VALUES(@cid, @cname);";

                sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                //sqlCommand.Parameters.AddWithValue("@table", table);
                sqlCommand.Parameters.AddWithValue("@cid", cid);
                sqlCommand.Parameters.AddWithValue("@cname", cname);

            }
            else
            {
                Console.WriteLine("    No such table\n");
                return;
            }

            Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Row(s) Inserted.\n\n");

        }*/

        /*public static void DeleteFrom()
        {
            try
            {
                if(table == "None")
                {
                    Console.WriteLine("    Table does not exist...");
                    Console.WriteLine("    No such table\n");
                    return;
                }

                string parametarizedQuery = "DELETE FROM " + table;

                SqlCommand? sqlCommand = null;

                Console.WriteLine("Do you want to add a condition [y/n]?");

                if(Console.ReadLine() == "y")
                {
                    Console.WriteLine("Enter a WHERE condition: ...");
                    string QueryCondition = Console.ReadLine();
    
                    parametarizedQuery += " WHERE " + QueryCondition;
                }

                sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);
    
                Console.WriteLine("    " + sqlCommand.ExecuteNonQuery() + " Row(s) deleted.\n\n");

            }
            catch(Exception e)
            {
                Console.WriteLine("    Error: " + e.Message);
            }
        }*/

        /*public static void Update()
        {
            try
            {
                if (table == "None")
                {
                    Console.WriteLine("Table does not exist...");
                    Console.WriteLine("No such table\n");
                    return;
                }

                string parametarizedQuery = "UPDATE " + table;

                SqlCommand? sqlCommand = null;

                Console.WriteLine("Enter an attribute to SET: ...");
                string QueryCondition = Console.ReadLine();

                parametarizedQuery += " SET " + QueryCondition;


                Console.WriteLine("Do you want to add a WHERE condition [y/n]?");

                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine("Enter a condition: ...");
                    QueryCondition = Console.ReadLine();

                    parametarizedQuery += " WHERE " + QueryCondition;
                }

                sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                Console.WriteLine("    " + sqlCommand.ExecuteNonQuery() + " Row(s) updated.\n\n");

            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }*/


        /*public static void select()
        {
            try
            {
                if (table == "None")
                {
                    //Console.WriteLine("Table does not exist...");
                    //Console.WriteLine("No such table\n");

                    Console.WriteLine("\n   No table selected... Please select a table.\n\n");
                    return;
                }

                SqlCommand? sqlCommand = null;


                string parametarizedQuery = "SELECT ";

                Console.WriteLine("Select attributes to project onto: ...   (pid, name, price, category) ");
                string SelectAttributes = Console.ReadLine();

                parametarizedQuery += " " + SelectAttributes + " ";


                parametarizedQuery += "FROM " + table;

                //Console.WriteLine("Enter an attribute to SET: ...");

                Console.WriteLine("Do you want to add a JOIN condition [y/n]?");

                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine("Select a join operation: ...  (JOIN, LEFT OUTTER JOIN, RIGHT OUTTER JOIN, FULL JOIN, CROSS JOIN)");
                    string JoinKind = Console.ReadLine();


                    parametarizedQuery += " " + JoinKind + " ";

                    Console.WriteLine("Enter a name of the other table: ...");
                    string OtherTable = Console.ReadLine();


                    parametarizedQuery += " " + OtherTable + " ";
                    parametarizedQuery += " ON ";

                    Console.WriteLine("Enter a join condition: ...");
                    string JoinCondition = Console.ReadLine();

                    parametarizedQuery += " " + JoinCondition + " ";


                }

                Console.WriteLine("Do you want to add a WHERE condition [y/n]?");

                if (Console.ReadLine() == "y")
                {
                    parametarizedQuery += " WHERE ";

                    Console.WriteLine("Enter a WHERE condition: ...");
                    string WhereCondition = Console.ReadLine();


                    parametarizedQuery += " " + WhereCondition + " ";

                }

                sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                //Console.WriteLine(sqlCommand.ExecuteNonQuery() + " Row(s) updated.");

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.Write(reader[0] + "\n");
                        Console.Write(reader[1] + "\n");
                        Console.WriteLine(reader[2]);
                        //Console.WriteLine(reader[3]);
                        Console.WriteLine("------------------------------");
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }*/



        public static void signup()
        {
            string parametarizedQuery;
            int account_id;
            try
            {
                Console.WriteLine("adding admin");
                Console.WriteLine("Enter admin secret key:");
                Console.WriteLine("(the key is 12345, this line will be removed in the real app)");
                string key = Console.ReadLine();
                if (key != "12345")
                {
                    Console.WriteLine("wrong key");
                    return;
                }
                Console.WriteLine("user name:");
                string user_name = Console.ReadLine();
                Console.WriteLine("email:");
                string email = Console.ReadLine();
                Console.WriteLine("password:");
                string password = Console.ReadLine();

                parametarizedQuery = "INSERT INTO accounts";
                parametarizedQuery += " VALUES(@user_name, @password, @email, @role); SELECT SCOPE_IDENTITY();";

                using (SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn))
                {
                    sqlCommand.Parameters.AddWithValue("@user_name", user_name);
                    sqlCommand.Parameters.AddWithValue("@password", password);
                    sqlCommand.Parameters.AddWithValue("@email", email);
                    sqlCommand.Parameters.AddWithValue("@role", "admin");
                    account_id = Convert.ToInt32(sqlCommand.ExecuteScalar());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
                return;
            }

            try
            {
                Console.WriteLine("admin_id:");
                admin_id = Console.ReadLine();

                Console.WriteLine("first_name: ");
                first_name = Console.ReadLine();

                Console.WriteLine("middle_name: ");
                middle_name = Console.ReadLine();

                Console.WriteLine("last_name: ");
                last_name = Console.ReadLine();

                Console.WriteLine("admin_address: ");
                admin_address = Console.ReadLine();

                parametarizedQuery = "INSERT INTO Admin";

                parametarizedQuery += " VALUES(@admin_id, @account_id, @first_name, @middle_name, @last_name, @admin_address);";


                using (SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn))
                {
                    sqlCommand.Parameters.AddWithValue("@admin_id", admin_id);
                    sqlCommand.Parameters.AddWithValue("@account_id", account_id);
                    sqlCommand.Parameters.AddWithValue("@first_name", first_name);
                    sqlCommand.Parameters.AddWithValue("@middle_name", middle_name);
                    sqlCommand.Parameters.AddWithValue("@last_name", last_name);
                    sqlCommand.Parameters.AddWithValue("@admin_address", admin_address);
                    Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " admin added.\n\n");
                }
                singedin_type = "admin";
                signedin_user_id = admin_id;
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
                parametarizedQuery = "DELETE FROM accounts WHERE account_id = @account_id";
                using (SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn))
                {
                    sqlCommand.Parameters.AddWithValue("@account_id", account_id);
                    sqlCommand.ExecuteNonQuery();
                }
                return;
            }
        }

        public static void signin()
        {
            Console.WriteLine("             ------------------");
            Console.WriteLine("            |                   |");
            Console.WriteLine("            |      sign in      |");
            Console.WriteLine("            |                   |");
            Console.WriteLine("             ------------------" + "\n");

            Console.Write("email: ");
            email = Console.ReadLine();

            Console.Write("password: ");
            password = Console.ReadLine();

            string check_query = $"SELECT role,account_id FROM accounts WHERE email = '{email}' AND password='{password}'";
            try
            {
                SqlCommand sc = new SqlCommand(check_query, sqlconn);

                using (SqlDataReader reader = sc.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        singedin_type = "" + reader[0];
                        singedin_account_id = int.Parse("" + reader[1]);
                        Console.WriteLine(singedin_type);
                        Console.WriteLine(singedin_account_id);
                    }
                    else
                    {
                        Console.WriteLine("the email or the password are wrong.please,try again.\n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }


            //     if (user == "1")
            //     {
            //         try
            //         {
            //             // Console.WriteLine("signing in a student");

            //             string temp_stud_id;
            //           //  SqlCommand comm = new SqlCommand(query, sqlconn);


            //             //using (SqlDataReader reader = comm.ExecuteReader())
            //             {

            //                 if (reader.Read())
            //                 {
            //                     Console.Write("Student with id: " + reader[0] + " is signed in\n");
            //                     signedin_user_id = temp_stud_id;
            //                     singedin_type = "student";

            //                 }
            //                 else
            //                 {
            //                     Console.WriteLine("No registered student with id: " + temp_stud_id);
            //                 }

            //             }

            //         }
            //         catch (Exception e)
            //         {
            //             Console.WriteLine("error: " + e.Message);
            //         }

            //     }
            //     else if (user == "2")
            //     {
            //         try
            //         {
            //             // Console.WriteLine("signing in a student");

            //             string temp_admin_id;

            //             Console.WriteLine("admin_id: ");
            //             temp_admin_id = Console.ReadLine();


            //             string query = "select * from Admin_data where admin_id = " + int.Parse(temp_admin_id);
            //             SqlCommand comm = new SqlCommand(query, sqlconn);


            //             using (SqlDataReader reader = comm.ExecuteReader())
            //             {

            //                 if (reader.Read())
            //                 {
            //                     Console.Write("admin with id: " + reader[0] + " is signed in\n");
            //                     signedin_user_id = temp_admin_id;
            //                     singedin_type = "admin";

            //                 }
            //                 else
            //                 {
            //                     Console.WriteLine("No registered admin with id: " + temp_admin_id);
            //                 }

            //             }

            //         }
            //         catch (Exception e)
            //         {
            //             Console.WriteLine("error: " + e.Message);
            //         }

            //     }
        }
        public static void manageCourses()
        {

            Console.WriteLine("             ------------------");
            Console.WriteLine("            |                   |");
            Console.WriteLine("            |      courses      |");
            Console.WriteLine("            |                   |");
            Console.WriteLine("             ------------------" + "\n");
            Console.WriteLine("1-show courses\n2-create course\n3-edit course\n4-delete course\n5-enrollig student in a course\n ");
            Console.Write("your choice: ");
            string ch = Console.ReadLine();
            if (ch == "1")
            {
                showCourses();
            }
            else if (ch == "2")
            {
                createCourse();
            }
            else if (ch == "3")
            {
                editCourse();
            }
            else if (ch == "4")
            {
                deleteCourse();
            }
            else if (ch == "5")
            {
                enrollingStudentInACourse();
            }
            else if (ch == "")
            {

            }


        }
        public static void showCourses()// error at option 3
        {
            Console.WriteLine("         ------------------");
            Console.WriteLine("        |                  |");
            Console.WriteLine("        |   show courses   |");
            Console.WriteLine("        |                  |");
            Console.WriteLine("         ------------------" + "\n\n");
            Console.WriteLine("1-show course details\n2-show all courses \n3-show all courses in specific department\n\n ");
            Console.Write("your choice: ");
            string ch = Console.ReadLine();
            if (ch == "1")
            {
                Console.Write("Enter the course id: ");
                string courseId = Console.ReadLine();
                string sqlQuery = $"SELECT * FROM course WHERE course_id = {courseId}";
                SqlCommand sComm = new SqlCommand(sqlQuery, sqlconn);
                using (SqlDataReader reader = sComm.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine("course id: " + reader[0]);
                        Console.WriteLine("department id: " + reader[1]);
                        Console.WriteLine("course name: " + reader[2]);
                        Console.WriteLine("credit hours: " + reader[3]);
                    }
                    else
                    {
                        Console.WriteLine("no course with that id");
                    }
                }

            }
            else if (ch == "2")
            {
                string sqlQuery = "SELECT * FROM course ";
                SqlCommand sComm = new SqlCommand(sqlQuery, sqlconn);
                using (SqlDataReader reader = sComm.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Console.WriteLine("------------------------------");
                        Console.WriteLine("course id: " + reader[0]);
                        Console.WriteLine("department id: " + reader[1]);
                        Console.WriteLine("course name: " + reader[2]);
                        Console.WriteLine("credit hours: " + reader[3]);
                        Console.WriteLine("------------------------------");
                    }
                }
            }
            else if (ch == "3")
            {
                Console.Write("Enter the department id: ");
                string departmentId = Console.ReadLine();
                string sqlQuery = $"SELECT * FROM Course WHERE department_id = {departmentId}";

                SqlCommand sComm = new SqlCommand(sqlQuery, sqlconn);
                using (SqlDataReader reader = sComm.ExecuteReader())
                {
                    Console.Write("111111111111111111111111111 ");
                    while (reader.Read())
                    {

                        Console.WriteLine("------------------------------");
                        Console.WriteLine("course id: " + reader[0]);
                        Console.WriteLine("department id: " + reader[1]);
                        Console.WriteLine("course name: " + reader[2]);
                        Console.WriteLine("credit hours: " + reader[3]);
                        Console.WriteLine("------------------------------");
                    }
                }
            }
        }
        public static void createCourse()
        {//philo

            Console.WriteLine("     -----------------------");
            Console.WriteLine("    |                       |");
            Console.WriteLine("    |   create new course   |");
            Console.WriteLine("    |                       |");
            Console.WriteLine("     -----------------------" + "\n\n");
            Console.Write("course id: ");
            string courseId = Console.ReadLine();
            Console.Write("department id: ");
            string departmentId = Console.ReadLine();
            Console.Write("course name: ");
            string courseName = Console.ReadLine();
            Console.Write("credit hours: ");
            int creditHours = int.Parse(Console.ReadLine());

            string addQuery = "INSERT INTO course VALUES(@courseId,@departmentId,@courseName,@creditHours)";
            try
            {
                SqlCommand sComm = new SqlCommand(addQuery, sqlconn);
                //sqlCommand.Parameters.AddWithValue("@table", table);
                sComm.Parameters.AddWithValue("@courseId", courseId);
                sComm.Parameters.AddWithValue("@departmentId", departmentId);
                sComm.Parameters.AddWithValue("@courseName", courseName);
                sComm.Parameters.AddWithValue("@creditHours", creditHours);
                Console.WriteLine("\n    " + sComm.ExecuteNonQuery() + " course added.\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
            Console.WriteLine("\n0-back\ne-exit\n");
            Console.Write("your choice: ");
            string ch = Console.ReadLine();
            if (ch == "e")
            {
                CloseConnAndExit();
            }


        }
        public static void editCourse()
        { //philo


            Console.WriteLine("          -------------------");
            Console.WriteLine("         |                   |");
            Console.WriteLine("         |    edit course    |");
            Console.WriteLine("         |                   |");
            Console.WriteLine("          -------------------" + "\n\n");
            Console.Write("Enter id of course that you want to edit it :");
            string courseId = Console.ReadLine();
            Console.WriteLine("1-change course id\n2-change department of course\n3-change course name\n4-change credit hours of course\n\n ");
            string ch = Console.ReadLine();
            if (ch == "1")
            {
                Console.Write("the new course id: ");
                string newCourseId = Console.ReadLine();
                string sqlQuery = "UPDATE  Course SET course_id = @newCourseId where course_id = @courseId";
                SqlCommand sComm = new SqlCommand(sqlQuery, sqlconn);

                sComm.Parameters.AddWithValue("newCourseId", newCourseId);
                sComm.Parameters.AddWithValue("courseId", courseId);
                Console.WriteLine("\n    " + sComm.ExecuteNonQuery() + " course id edited.\n\n");

            }
            else if (ch == "2")
            {
                Console.Write("the new department id: ");
                string newDepartmentId = Console.ReadLine();
                string sqlQuery = "UPDATE  Course SET department_id = @newDepartmentId where course_id = @courseId";
                SqlCommand sComm = new SqlCommand(sqlQuery, sqlconn);

                sComm.Parameters.AddWithValue("newDepartmentId", newDepartmentId);
                sComm.Parameters.AddWithValue("courseId", courseId);
                Console.WriteLine("\n    " + sComm.ExecuteNonQuery() + "department id of course edited.\n\n");

            }
            else if (ch == "3")
            {
                Console.Write("the new course name: ");
                string newCourseName = Console.ReadLine();
                string sqlQuery = "UPDATE  Course SET course_name = @newCourseName where course_id = @courseId";
                SqlCommand sComm = new SqlCommand(sqlQuery, sqlconn);

                sComm.Parameters.AddWithValue("newCourseName", newCourseName);
                sComm.Parameters.AddWithValue("courseId", courseId);
                Console.WriteLine("\n    " + sComm.ExecuteNonQuery() + " course name edited.\n\n");

            }
            else if (ch == "4")
            {
                Console.Write("the new credit hours: ");
                int newCreditHours = int.Parse(Console.ReadLine());
                string sqlQuery = "UPDATE  Course SET credit_hours = @newCreditHours where course_id = @courseId";
                SqlCommand sComm = new SqlCommand(sqlQuery, sqlconn);

                sComm.Parameters.AddWithValue("newCreditHours", newCreditHours);
                sComm.Parameters.AddWithValue("courseId", courseId);
                Console.WriteLine("\n    " + sComm.ExecuteNonQuery() + " credit hours of course edited.\n\n");

            }
            else if (ch == "")
            {

            }

        }
        public static void deleteCourse()
        {
            Console.WriteLine("          -------------------");
            Console.WriteLine("         |                   |");
            Console.WriteLine("         |   delete course   |");
            Console.WriteLine("         |                   |");
            Console.WriteLine("          -------------------" + "\n\n");
            Console.WriteLine("1-delete course by id\n2-delete course by name\n ");
            string ch = Console.ReadLine();
            if (ch == "1")
            {
                Console.Write("Enter course id: ");
                string courseId = Console.ReadLine();
                string sqlQuery = "DELETE FROM  Course where course_id = @courseId";
                SqlCommand sComm = new SqlCommand(sqlQuery, sqlconn);

                sComm.Parameters.AddWithValue("courseId", courseId);
                Console.WriteLine("\n    " + sComm.ExecuteNonQuery() + " course deleted.\n\n");

            }
            else if (ch == "2")
            {
                Console.Write("Enter course name: ");
                string courseName = Console.ReadLine();
                string sqlQuery = "DELETE FROM  Course where course_name = @courseName";
                SqlCommand sComm = new SqlCommand(sqlQuery, sqlconn);

                sComm.Parameters.AddWithValue("courseName", courseName);
                Console.WriteLine("\n    " + sComm.ExecuteNonQuery() + "course deleted.\n\n");

            }
            else if (ch == "")
            {

            }

        }
        public static void enrollingStudentInACourse()// un checked
        {
            Console.WriteLine("          ------------------------------------------");
            Console.WriteLine("         |                                           |");
            Console.WriteLine("         |   enrolling students in a course course   |");
            Console.WriteLine("         |                                           |");
            Console.WriteLine("          -------------------------------------------" + "\n\n");
            Console.Write("Enter the course id: ");
            string courseId = Console.ReadLine();
            string sqlQuery = $"SELECT student_id,student_first_name,student_middle_name,student_last_name,entry_year FROM enrolls OUTER LEFT JOIN Student on enrolls.student_id=Student.student_id where course_id={courseId} ";
            SqlCommand sComm = new SqlCommand(sqlQuery, sqlconn);
            using (SqlDataReader reader = sComm.ExecuteReader())
            {
                while (reader.Read())
                {

                    Console.WriteLine("------------------------------");
                    Console.WriteLine("id: " + reader[0]);
                    Console.WriteLine("first name: " + reader[1]);
                    Console.WriteLine("middle name: " + reader[2]);
                    Console.WriteLine("last name: " + reader[3]);
                    Console.WriteLine("entry year: " + reader[4]);
                    Console.WriteLine("------------------------------");
                }
            }
        }
        public static void showEnrollingCourses()// un checked
        {
            Console.WriteLine("          -----------------------");
            Console.WriteLine("         |                       |");
            Console.WriteLine("         |   enrolling courses   |");
            Console.WriteLine("         |                       |");
            Console.WriteLine("          -----------------------" + "\n\n");
            string sqlQuery1 = $"SELECT student_id FROM Student where account_id={singedin_account_id} ";
            int studentId = 0;
            SqlCommand sComm1 = new SqlCommand(sqlQuery1, sqlconn);
            using (SqlDataReader reader = sComm1.ExecuteReader())
            {
                if (reader.Read())
                {
                    studentId = int.Parse("" + reader[0]);
                }
            }

            string sqlQuery2 = $"SELECT course_id,department_id,course_name,credit_hours FROM enrolls OUTER LEFT JOIN Course on enrolls.Course=Course.Course where student_id={studentId} ";
            SqlCommand sComm2 = new SqlCommand(sqlQuery2, sqlconn);
            using (SqlDataReader reader = sComm2.ExecuteReader())
            {
                while (reader.Read())
                {

                    Console.WriteLine("------------------------------");
                    Console.WriteLine("course id: " + reader[0]);
                    Console.WriteLine("department id: " + reader[1]);
                    Console.WriteLine("course name: " + reader[2]);
                    Console.WriteLine("credit hours: " + reader[3]);
                    Console.WriteLine("------------------------------");
                }
            }
        }
        public static void show_student_data()
        {
            string query = "select * from student where student_id = " + int.Parse(signedin_user_id);
            SqlCommand comm = new SqlCommand(query, sqlconn);


            using (SqlDataReader reader = comm.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("student_id: " + reader[0]);
                    Console.WriteLine("first_name: " + reader[1]);
                    Console.WriteLine("middle_name: " + reader[2]);
                    Console.WriteLine("last_name: " + reader[3]);
                    Console.WriteLine("address: " + reader[4]);
                    Console.WriteLine("department_id: " + reader[5]);

                }
                else
                {
                    Console.WriteLine("No signed in user");
                }

            }

        }
        public static void show_admin_data()
        {
            string query = "select * from Admin_data where admin_id = " + int.Parse(signedin_user_id);
            SqlCommand comm = new SqlCommand(query, sqlconn);


            using (SqlDataReader reader = comm.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("admin_id: " + reader[0]);
                    Console.WriteLine("first_name: " + reader[1]);
                    Console.WriteLine("middle_name: " + reader[2]);
                    Console.WriteLine("last_name: " + reader[3]);
                    Console.WriteLine("admin_address: " + reader[4]);
                }
                else
                {
                    Console.WriteLine("No signed in user");
                }

            }
        }
        public static void edit_student_data()
        {
            try
            {

                string replacment_first_name;
                string replacment_middle_name;
                string replacment_last_name;
                string replacment_address;
                string replacment_department_id;


                Console.WriteLine("editing student");

                Console.WriteLine("first_name: ");
                replacment_first_name = Console.ReadLine();

                Console.WriteLine("middle_name: ");
                replacment_middle_name = Console.ReadLine();

                Console.WriteLine("last_name: ");
                replacment_last_name = Console.ReadLine();

                Console.WriteLine("address: ");
                replacment_address = Console.ReadLine();

                Console.WriteLine("department_id: ");
                replacment_department_id = Console.ReadLine();


                string query = "update student " +
                               "set first_name = @replacment_first_name, middle_name = @replacment_middle_name, "
                             + "last_name = @replacment_last_name, address = @replacment_address, " +
                               "department_id = @replacment_department_id ";
                query += "where student_id = " + int.Parse(signedin_user_id);


                SqlCommand comm = new SqlCommand(query, sqlconn);

                comm.Parameters.AddWithValue("@replacment_first_name", replacment_first_name);
                comm.Parameters.AddWithValue("@replacment_middle_name", replacment_middle_name);
                comm.Parameters.AddWithValue("@replacment_last_name", replacment_last_name);
                comm.Parameters.AddWithValue("@replacment_address", replacment_address);
                comm.Parameters.AddWithValue("@replacment_department_id", replacment_department_id);

                Console.WriteLine("\n    " + comm.ExecuteNonQuery() + " student edited.\n\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }
        public static void edit_admin_data()
        {
            try
            {

                string replacment_first_name;
                string replacment_middle_name;
                string replacment_last_name;
                string replacment_admin_address;


                Console.WriteLine("editing student");

                Console.WriteLine("first_name: ");
                replacment_first_name = Console.ReadLine();

                Console.WriteLine("middle_name: ");
                replacment_middle_name = Console.ReadLine();

                Console.WriteLine("last_name: ");
                replacment_last_name = Console.ReadLine();

                Console.WriteLine("address: ");
                replacment_admin_address = Console.ReadLine();


                string query = "update Admin_data " +
                               "set first_name = @replacment_first_name, middle_name = @replacment_middle_name, "
                             + "last_name = @replacment_last_name, admin_address = @replacment_admin_address ";
                query += "where admin_id = " + int.Parse(signedin_user_id);


                SqlCommand comm = new SqlCommand(query, sqlconn);

                comm.Parameters.AddWithValue("@replacment_first_name", replacment_first_name);
                comm.Parameters.AddWithValue("@replacment_middle_name", replacment_middle_name);
                comm.Parameters.AddWithValue("@replacment_last_name", replacment_last_name);
                comm.Parameters.AddWithValue("@replacment_admin_address", replacment_admin_address);

                Console.WriteLine("\n    " + comm.ExecuteNonQuery() + " admin edited.\n\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }
        public static void add_course()
        {
            try
            {
                string course_id;
                string course_name;
                string credit_hours;
                string department_id;

                Console.WriteLine("adding course");

                Console.WriteLine("course_id: ");
                course_id = Console.ReadLine();

                Console.WriteLine("course_name: ");
                course_name = Console.ReadLine();

                Console.WriteLine("credit_hours: ");
                credit_hours = Console.ReadLine();

                Console.WriteLine("department_id: ");
                department_id = Console.ReadLine();


                string parametarizedQuery = "INSERT INTO " + "course";

                parametarizedQuery += " VALUES(@course_id, @course_name, @credit_hours, @department_id);";

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                //sqlCommand.Parameters.AddWithValue("@table", table);
                sqlCommand.Parameters.AddWithValue("@course_id", course_id);
                sqlCommand.Parameters.AddWithValue("@course_name", course_name);
                sqlCommand.Parameters.AddWithValue("@credit_hours", credit_hours);
                sqlCommand.Parameters.AddWithValue("@department_id", department_id);

                Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " course added.\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }
        public static void add_department()
        {
            try
            {
                string department_id;
                string department_name;


                Console.WriteLine("adding department");

                Console.WriteLine("department id: ");
                department_id = Console.ReadLine();

                Console.WriteLine("department name: ");
                department_name = Console.ReadLine();


                string parametarizedQuery = "INSERT INTO " + "Department";

                parametarizedQuery += " VALUES(@department_Id, @department_name);";

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                sqlCommand.Parameters.AddWithValue("@department_Id", department_id);
                sqlCommand.Parameters.AddWithValue("@department_name", department_name);


                Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " department added.\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void CloseConnAndExit()  // Close the connection
        {
            if (sqlconn != null)
            {
                sqlconn.Close();
                Console.WriteLine("Database disconnected");
                //Console.WriteLine("Thank you <3");
            }
            else
            {
                //Console.WriteLine("No connected database");
            }
            Environment.Exit(0);

        }

        public static void manage_department()
        {
            string option = "1";
            while (option != "e") // continue while invalid option
            {
                Console.WriteLine("\nPlease Select an option to continue: " + "\n");
                Console.WriteLine("0- Go Back.");
                Console.WriteLine("1- Show all departments");
                Console.WriteLine("2- Add department");
                Console.WriteLine("3- Edit department");
                Console.WriteLine("4- Delete department");
                Console.WriteLine("5- Assign students to a department");
                Console.WriteLine("e- Exit.");
                Console.Write("Enter your choise: ");
                option = Console.ReadLine();
                if (option == "0")
                {
                    return;
                }
                if (option == "e")
                {
                    CloseConnAndExit();
                }
                if (option == "1") //show all departments
                {
                    string query = "select * from Department";
                    SqlCommand comm = new SqlCommand(query, sqlconn);
                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        Console.WriteLine("\n------------------------------");
                        while (reader.Read())
                        {
                            Console.WriteLine("department_id: " + reader[0]);
                            Console.WriteLine("department_name: " + reader[1]);
                            Console.WriteLine("------------------------------");
                        }
                    }
                }
                else if (option == "2") //add department
                {
                    add_department();
                }
                else if (option == "3") //edit department
                {
                    string query = "UPDATE Department SET department_name = @department_name WHERE department_id = @department_id";
                    try
                    {
                        string department_name;
                        string department_id;

                        Console.WriteLine("editing department");

                        Console.WriteLine("department id: ");
                        department_id = Console.ReadLine();

                        Console.WriteLine("department name: ");
                        department_name = Console.ReadLine();

                        SqlCommand sqlCommand = new SqlCommand(query, sqlconn);

                        sqlCommand.Parameters.AddWithValue("@department_name", department_name);
                        sqlCommand.Parameters.AddWithValue("@department_id", department_id);

                        Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " department edited.\n\n");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("error: " + e.Message);
                    }
                }
                else if (option == "4") //delete department
                {
                    try
                    {
                        string department_id;

                        Console.WriteLine("deleting department");

                        Console.WriteLine("department id: ");
                        department_id = Console.ReadLine();

                        string query = "DELETE from Department where department_id = @department_id";

                        SqlCommand sqlCommand = new SqlCommand(query, sqlconn);

                        sqlCommand.Parameters.AddWithValue("@department_id", department_id);

                        Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " department deleted.\n\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("error: " + e.Message);
                    }
                }
                else if (option == "5") //assign students to a department
                {
                    try
                    {
                        string student_id;
                        string department_id;

                        Console.WriteLine("assigning student to a department");

                        Console.WriteLine("student id: ");
                        student_id = Console.ReadLine();

                        Console.WriteLine("department id: ");
                        department_id = Console.ReadLine();

                        string query = "UPDATE Student SET department_id = @department_id ";
                        query += "WHERE student_id = @student_id";

                        SqlCommand sqlCommand = new SqlCommand(query, sqlconn);

                        sqlCommand.Parameters.AddWithValue("@department_id", department_id);
                        sqlCommand.Parameters.AddWithValue("@student_id", student_id);

                        Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " student assigned to a department.\n\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("error: " + e.Message);
                    }
                }
                else
                {
                    Console.Write("\n invalid option.please,try agien.\n");
                }
            }
        }

        public static void manage_profile()
        {
            string option = "1";
            string query = $"SELECT student_id FROM Student WHERE account_id={signedin_user_id}";
            string student_id = "";
            using (SqlCommand sqlCommand = new SqlCommand(query, sqlconn))
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        student_id = "" + reader[0];
                    }
                }
            }
            while (option != "e") // continue while invalid option
            {
                Console.WriteLine("\nPlease Select an option to continue: " + "\n");
                Console.WriteLine("0- Go Back.");
                Console.WriteLine("1- Show profile.");
                Console.WriteLine("2- Edit profile");
                Console.WriteLine("3- Add phone number");
                Console.WriteLine("4- Delete phone number");
                Console.WriteLine("e- Exit.");
                Console.Write("Enter your choise: ");
                option = Console.ReadLine();
                if (option == "0")
                {
                    return;
                }
                if (option == "e")
                {
                    CloseConnAndExit();
                }
                if (option == "1")
                {
                    try
                    {
                        query = "SELECT user_name, email from accounts ";
                        query += $"WHERE account_id = {signedin_user_id}";

                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlconn))
                        {
                            using (SqlDataReader reader = sqlCommand.ExecuteReader())
                            {
                                Console.WriteLine("Account Info:");
                                reader.Read();
                                Console.WriteLine("user_name: " + reader[0]);
                                Console.WriteLine("email: " + reader[1]);
                            }
                        }

                        query = "SELECT student_id, department_name, student_first_name, student_middle_name, student_last_name, entry_year, student_address FROM Student ";
                        query += $"JOIN Department ON Department.department_id = Student.department_id";
                        query += $"WHERE student_id = '{student_id}'";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlconn))
                        {
                            using (SqlDataReader reader = sqlCommand.ExecuteReader())
                            {
                                Console.WriteLine("Student Info:");
                                reader.Read();
                                Console.WriteLine("Student ID: " + reader[0]);
                                Console.WriteLine("Student Department: " + reader[1]);
                                string full_name = reader[2] + " " + reader[3] + " " + reader[4];
                                Console.WriteLine("Student Name: " + full_name);
                                Console.WriteLine("Entry Year: " + reader[5]);
                                Console.WriteLine("Student Address: " + reader[6]);
                            }
                        }

                        query = $"SELECT phone_number FROM phones WHERE account_id = {signedin_user_id}";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlconn))
                        {
                            using (SqlDataReader reader = sqlCommand.ExecuteReader())
                            {
                                Console.WriteLine("Phone numbers:");
                                while (reader.Read())
                                {
                                    Console.WriteLine(reader[0]);
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("error: " + e.Message);
                    }
                }
                else if (option == "2")
                {
                    string edit_option = "1";
                    Console.WriteLine("1- Edit password");
                    Console.WriteLine("2- Edit address");
                    if (edit_option == "1")
                    {
                        Console.WriteLine("Enter new password: ");
                        string new_password = Console.ReadLine();
                        query = $"UPDATE accounts SET password='{new_password}' WHERE account_id={signedin_user_id}";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlconn))
                        {
                            Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " password edited.\n\n");
                        }
                    }
                    else if (edit_option == "2")
                    {
                        Console.WriteLine("Enter new address: ");
                        string new_address = Console.ReadLine();
                        query = $"UPDATE Student SET student_address='{new_address}' WHERE student_id='{student_id}'";
                        using (SqlCommand sqlCommand = new SqlCommand(query, sqlconn))
                        {
                            Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " address edited.\n\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option");
                    }

                }
                else if (option == "3")
                {
                    Console.WriteLine("Enter new phone number: ");
                    string new_phone = Console.ReadLine();
                    query = $"INSERT INTO phones VALUES({signedin_user_id}, '{new_phone}')";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlconn))
                    {
                        Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " phone added.\n\n");
                    }
                }
                else if (option == "4")
                {
                    Console.WriteLine("Enter phone number to delete: ");
                    string phone = Console.ReadLine();
                    query = $"DELETE FROM phones WHERE account_id={signedin_user_id} AND phone_number='{phone}'";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlconn))
                    {
                        Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " phone deleted.\n\n");
                    }
                }
                else
                {
                    Console.Write("\n invalid option.please,try agien.\n");
                }
            }
        }


        public static void AddStudent()
        {

            try
            {

                int account_id;
                string user_name;
                string password;
                string email;
                string role;

                string student_id = "";
                string department_id;
                string student_first_name;
                string student_middle_name;
                string student_last_name;
                string entry_year;
                string student_address;

                Console.WriteLine("adding a student with his account");


                Console.WriteLine("user_name: ");
                user_name = Console.ReadLine();

                Console.WriteLine("password: ");
                password = Console.ReadLine();

                Console.WriteLine("email: ");
                email = Console.ReadLine();

                Console.WriteLine("role: ");
                role = Console.ReadLine();


                Console.WriteLine("student_id: ");
                student_id = Console.ReadLine();

                Console.WriteLine("department_id: ");
                department_id = Console.ReadLine();

                Console.WriteLine("student_first_name: ");
                student_first_name = Console.ReadLine();

                Console.WriteLine("student_middle_name: ");
                student_middle_name = Console.ReadLine();

                Console.WriteLine("student_last_name: ");
                student_last_name = Console.ReadLine();

                Console.WriteLine("entry_year: ");
                entry_year = Console.ReadLine();

                Console.WriteLine("student_address: ");
                student_address = Console.ReadLine();



                string prequery = "INSERT INTO accounts " +
                                  " VALUES('" + user_name + "', '" + password + "', '" + email + "', '" + role + "');" +
                                  " SELECT SCOPE_IDENTITY();";
                //Console.WriteLine(prequery                                                                                       //Environment.Exit(0);
                SqlCommand precommand = new SqlCommand(prequery, sqlconn);

                account_id = Convert.ToInt32(precommand.ExecuteScalar());
                Console.WriteLine("\n     1 account added.\n\n");



                string parametarizedQuery = "INSERT INTO " + "Student ";

                parametarizedQuery += " VALUES(@student_id, @department_id, @account_id, @student_first_name," +
                                      " @student_middle_name, @student_last_name, @entry_year, @student_address);";

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                sqlCommand.Parameters.AddWithValue("@student_id", student_id);
                sqlCommand.Parameters.AddWithValue("@department_id", department_id);
                sqlCommand.Parameters.AddWithValue("@account_id", account_id);
                sqlCommand.Parameters.AddWithValue("@student_first_name", student_first_name);
                sqlCommand.Parameters.AddWithValue("@student_middle_name", student_middle_name);
                sqlCommand.Parameters.AddWithValue("@student_last_name", student_last_name);
                sqlCommand.Parameters.AddWithValue("@entry_year", entry_year);
                sqlCommand.Parameters.AddWithValue("@student_address", student_address);

                Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student added.\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);

                //string deleteQuery = "DELETE FROM " + "accounts " +
                //                            " where account_id = " + student_id + ";";

                //SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlconn);
                //Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " account deleted.\n");

            }
        }

        public static void EditStudent()
        {

            try
            {
                int account_id;
                string user_name;
                string password;
                string email;
                string role;

                string student_id = "";
                string department_id;
                string student_first_name;
                string student_middle_name;
                string student_last_name;
                string entry_year;
                string student_address;

                Console.WriteLine("editing a student and his account");


                Console.WriteLine("student_id: ");
                student_id = Console.ReadLine();


                Console.WriteLine("user_name: ");
                user_name = Console.ReadLine();

                Console.WriteLine("password: ");
                password = Console.ReadLine();

                Console.WriteLine("email: ");
                email = Console.ReadLine();

                Console.WriteLine("role: ");
                role = Console.ReadLine();


                Console.WriteLine("department_id: ");
                department_id = Console.ReadLine();

                Console.WriteLine("student_first_name: ");
                student_first_name = Console.ReadLine();

                Console.WriteLine("student_middle_name: ");
                student_middle_name = Console.ReadLine();

                Console.WriteLine("student_last_name: ");
                student_last_name = Console.ReadLine();

                Console.WriteLine("entry_year: ");
                entry_year = Console.ReadLine();

                Console.WriteLine("student_address: ");
                student_address = Console.ReadLine();

                string preprequery = $"select account_id from Student where student_id = {student_id}";
                SqlCommand preprecommand = new SqlCommand(preprequery, sqlconn);
                account_id = Convert.ToInt32(preprecommand.ExecuteScalar());
                //Console.WriteLine("--" + account_id + "--");


                string prequery = "update accounts " +
                                  $"set  user_name = '{user_name}',  password = '{password}',  email = '{email}', role = '{role}'" +
                                  $" where account_id = {account_id}";


                SqlCommand precommand = new SqlCommand(prequery, sqlconn);
                Console.WriteLine("\n    " + precommand.ExecuteNonQuery() + " account edited.\n\n");


                string parametarizedQuery = "update " + "Student ";
                parametarizedQuery += " set department_id = @department_id, student_first_name = @student_first_name," +
                                     " student_middle_name = @student_middle_name, student_last_name = @student_last_name, entry_year = @entry_year, student_address = @student_address";
                parametarizedQuery += " where student_id = " + student_id;

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);


                sqlCommand.Parameters.AddWithValue("@department_id", department_id);
                sqlCommand.Parameters.AddWithValue("@student_first_name", student_first_name);
                sqlCommand.Parameters.AddWithValue("@student_middle_name", student_middle_name);
                sqlCommand.Parameters.AddWithValue("@student_last_name", student_last_name);
                sqlCommand.Parameters.AddWithValue("@entry_year", entry_year);
                sqlCommand.Parameters.AddWithValue("@student_address", student_address);

                Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student edited.\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void DeleteStudent()
        {


            try
            {
                int account_id;
                string student_id = "";

                Console.WriteLine("Deleting a student and his account");

                Console.WriteLine("student_id: ");
                student_id = Console.ReadLine();





                string preprequery = $"select account_id from Student where student_id = {student_id}";
                SqlCommand preprecommand = new SqlCommand(preprequery, sqlconn);
                account_id = Convert.ToInt32(preprecommand.ExecuteScalar());
                Console.WriteLine("--" + account_id + "--");


                string parametarizedQuery = "DELETE FROM " + "Student " +
                                            " where student_id = " + student_id;

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);
                Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student deleted.\n");


                string prequery = "DELETE FROM accounts " +
                                 $" where account_id = {account_id}";

                SqlCommand precommand = new SqlCommand(prequery, sqlconn);
                Console.WriteLine("\n    " + precommand.ExecuteNonQuery() + " account deleted.\n\n");


            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void ShowStudentById()
        {
            try
            {
                string student_id = "";

                Console.WriteLine("showing a student by id");

                Console.WriteLine("student_id: ");
                student_id = Console.ReadLine();



                string parametarizedQuery = "SELECT * FROM " + "accounts, Student " +
                                            " where accounts.account_id = Student.account_id" +
                                            " and student_id = " + student_id;

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);
                //Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student deleted.\n");

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine();
                        Console.WriteLine("account_id: ........... " + reader[0]);
                        Console.WriteLine("User_name: ............ " + reader[1]);
                        Console.WriteLine("password: ............. " + reader[2]);
                        Console.WriteLine("email: ................ " + reader[3]);
                        Console.WriteLine("role: ................. " + reader[4]);
                        Console.WriteLine("student_id: ........... " + reader[5]);
                        Console.WriteLine("depertment_id: ........ " + reader[6]);
                        //Console.WriteLine("middle_name:      ... " + reader[7]);
                        Console.WriteLine("student_first_name: ... " + reader[8]);
                        Console.WriteLine("student_middle_name: .. " + reader[9]);
                        Console.WriteLine("student_last_name: .... " + reader[10]);
                        Console.WriteLine("entry_year: ........... " + reader[11]);
                        Console.WriteLine("student_address: ...... " + reader[12]);
                        Console.WriteLine("---------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("No registered Student with such ID...");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void ShowAllStudents()
        {
            try
            {
                Console.WriteLine("showing all students ");

                string parametarizedQuery = "SELECT * FROM " + "accounts, Student " +
                                            " where accounts.account_id = Student.account_id";

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);
                //Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student deleted.\n");

                int count = 1;
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Student #" + count + ":");
                        Console.WriteLine();
                        Console.WriteLine("account_id: ........... " + reader[0]);
                        Console.WriteLine("User_name: ............ " + reader[1]);
                        Console.WriteLine("password: ............. " + reader[2]);
                        Console.WriteLine("email: ................ " + reader[3]);
                        Console.WriteLine("role: ................. " + reader[4]);
                        Console.WriteLine("student_id: ........... " + reader[5]);
                        Console.WriteLine("depertment_id: ........ " + reader[6]);
                        //Console.WriteLine("middle_name:      ... " + reader[7]);
                        Console.WriteLine("student_first_name: ... " + reader[8]);
                        Console.WriteLine("student_middle_name: .. " + reader[9]);
                        Console.WriteLine("student_last_name: .... " + reader[10]);
                        Console.WriteLine("entry_year: ........... " + reader[11]);
                        Console.WriteLine("student_address: ...... " + reader[12]);
                        Console.WriteLine("---------------------------------------");
                        count++;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void ShowAllSatisfying()
        {
            try
            {
                Console.WriteLine("showing all students satisfying a certain criteria");

                string department_id = "";
                string year = "";
                string cousre = "";
                string GPA = "";

                bool department_id_bool = false;
                bool year_bool = false;
                bool cousre_bool = false;
                bool GPA_bool = false;

                Console.WriteLine("Add department constraint?  [y/n]");
                if (Console.ReadLine() == "y")
                {
                    department_id_bool = true;
                    Console.WriteLine("department_id: ");
                    department_id = Console.ReadLine();
                }

                Console.WriteLine("Add Graduation Year constraint?  [y/n]");
                if (Console.ReadLine() == "y")
                {
                    year_bool = true;
                    Console.WriteLine("year: ");
                    year = Console.ReadLine();
                }

                Console.WriteLine("Add Course constraint?  [y/n]");
                if (Console.ReadLine() == "y")
                {
                    cousre_bool = true;
                    Console.WriteLine("cousre: ");
                    cousre = Console.ReadLine();
                }

                Console.WriteLine("Add GPA constraint?  [y/n]");
                if (Console.ReadLine() == "y")
                {
                    GPA_bool = true;
                    Console.WriteLine("GPA: ");
                    GPA = Console.ReadLine();
                }


                string parametarizedQuery = "SELECT * FROM " + "accounts, Student " +
                                            " where accounts.account_id = Student.account_id";

                if (department_id_bool)
                {
                    parametarizedQuery += " and department_id = " + department_id;

                }

                if (year_bool)
                {
                    parametarizedQuery += " and entry_year = " + year;

                }

                // if (cousre_bool)
                // {
                //     parametarizedQuery += " and department_id = " + department_id;

                // }

                // if (GPA_bool)
                // {
                //    parametarizedQuery += " and department_id = " + department_id;

                // }

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);
                //Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student deleted.\n");

                int count = 1;
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Student #" + count + ":");
                        Console.WriteLine();
                        Console.WriteLine("account_id: ........... " + reader[0]);
                        Console.WriteLine("User_name: ............ " + reader[1]);
                        Console.WriteLine("password: ............. " + reader[2]);
                        Console.WriteLine("email: ................ " + reader[3]);
                        Console.WriteLine("role: ................. " + reader[4]);
                        Console.WriteLine("student_id: ........... " + reader[5]);
                        Console.WriteLine("depertment_id: ........ " + reader[6]);
                        //Console.WriteLine("middle_name:      ... " + reader[7]);
                        Console.WriteLine("student_first_name: ... " + reader[8]);
                        Console.WriteLine("student_middle_name: .. " + reader[9]);
                        Console.WriteLine("student_last_name: .... " + reader[10]);
                        Console.WriteLine("entry_year: ........... " + reader[11]);
                        Console.WriteLine("student_address: ...... " + reader[12]);
                        Console.WriteLine("--------------------------------------");
                        count++;
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void AddStaff()
        {

            try
            {

                string staff_id = "";
                string department_id;
                string staff_first_name;
                string staff_middle_name;
                string staff_last_name;


                Console.WriteLine("adding a staff member");

                Console.WriteLine("staff_id: ");
                staff_id = Console.ReadLine();

                Console.WriteLine("department_id: ");
                department_id = Console.ReadLine();

                Console.WriteLine("staff_first_name: ");
                staff_first_name = Console.ReadLine();

                Console.WriteLine("staff_middle_name: ");
                staff_middle_name = Console.ReadLine();

                Console.WriteLine("staff_last_name: ");
                staff_last_name = Console.ReadLine();


                string parametarizedQuery = "INSERT INTO " + "Staff ";

                parametarizedQuery += " VALUES(@staff_id, @department_id, @staff_first_name," +
                                      " @staff_middle_name, @staff_last_name);";

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                sqlCommand.Parameters.AddWithValue("@staff_id", staff_id);
                sqlCommand.Parameters.AddWithValue("@department_id", department_id);
                sqlCommand.Parameters.AddWithValue("@staff_first_name", staff_first_name);
                sqlCommand.Parameters.AddWithValue("@staff_middle_name", staff_middle_name);
                sqlCommand.Parameters.AddWithValue("@staff_last_name", staff_last_name);

                Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " staff member added.\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);

            }
        }

        public static void EditStaff()
        {

            try
            {
                string staff_id = "";
                string department_id;
                string staff_first_name;
                string staff_middle_name;
                string staff_last_name;


                Console.WriteLine("editing a staff member");

                Console.WriteLine("staff_id: ");
                staff_id = Console.ReadLine();


                // Console.WriteLine("department_id: ");
                // department_id = Console.ReadLine();

                Console.WriteLine("staff_first_name: ");
                staff_first_name = Console.ReadLine();

                Console.WriteLine("staff_middle_name: ");
                staff_middle_name = Console.ReadLine();

                Console.WriteLine("staff_last_name: ");
                staff_last_name = Console.ReadLine();


                string parametarizedQuery = "update " + "Staff  ";
                parametarizedQuery += " set staff_first_name = @staff_first_name," +
                                     " staff_middle_name = @staff_middle_name, staff_last_name = @staff_last_name";
                parametarizedQuery += " where staff_id = " + staff_id;
                // department_id = @department_id,

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                //sqlCommand.Parameters.AddWithValue("@department_id", department_id);
                sqlCommand.Parameters.AddWithValue("@staff_first_name", staff_first_name);
                sqlCommand.Parameters.AddWithValue("@staff_middle_name", staff_middle_name);
                sqlCommand.Parameters.AddWithValue("@staff_last_name", staff_last_name);

                Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " staff member updated.\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void DeleteStaff()
        {

            try
            {
                string staff_id = "";

                Console.WriteLine("Deleteing a staff member");

                Console.WriteLine("staff_id: ");
                staff_id = Console.ReadLine();


                string prequery = "DELETE FROM Staff  " +
                                 $" where staff_id = {staff_id}";

                SqlCommand precommand = new SqlCommand(prequery, sqlconn);
                Console.WriteLine("\n    " + precommand.ExecuteNonQuery() + " staff member deleted.\n\n");


            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void ShowStaffById()
        {
            try
            {
                string staff_id = "";

                Console.WriteLine("showing a staff member by id");

                Console.WriteLine("staff_id: ");
                staff_id = Console.ReadLine();



                string parametarizedQuery = "SELECT * FROM " + "Staff " +
                                            //" where accounts.account_id = Student.account_id" +
                                            " where staff_id = " + staff_id;

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);
                //Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student deleted.\n");

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine();
                        Console.WriteLine("staff_id: .............. " + reader[0]);
                        Console.WriteLine("department_id: ......... " + reader[1]);
                        Console.WriteLine("staff_first_name: ...... " + reader[2]);
                        Console.WriteLine("staff_middle_name: ..... " + reader[3]);
                        Console.WriteLine("staff_last_name: ....... " + reader[4]);
                    }
                    else
                    {
                        Console.WriteLine("No registered Student with such ID...");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void ShowAllStaff()
        {
            try
            {
                Console.WriteLine("showing all Staff members ");

                string parametarizedQuery = "SELECT * FROM " + "Staff ";

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);
                //Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student deleted.\n");

                int count = 1;
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("Staff member #" + count + ":");
                        Console.WriteLine();
                        Console.WriteLine("staff_id: .............. " + reader[0]);
                        Console.WriteLine("department_id: ......... " + reader[1]);
                        Console.WriteLine("staff_first_name: ...... " + reader[2]);
                        Console.WriteLine("staff_middle_name: ..... " + reader[3]);
                        Console.WriteLine("staff_last_name: ....... " + reader[4]);
                        Console.WriteLine("--------------------------------------");
                        count++;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void AddAdmin()
        {

            try
            {
                int account_id;
                string user_name;
                string password;
                string email;
                string role;

                string admin_id = "";
                string admin_first_name;
                string admin_middle_name;
                string admin_last_name;
                string admin_address;

                Console.WriteLine("adding an admin with his account");


                Console.WriteLine("user_name: ");
                user_name = Console.ReadLine();

                Console.WriteLine("password: ");
                password = Console.ReadLine();

                Console.WriteLine("email: ");
                email = Console.ReadLine();

                Console.WriteLine("role: ");
                role = Console.ReadLine();


                Console.WriteLine("admin_id: ");
                admin_id = Console.ReadLine();

                Console.WriteLine("admin_first_name: ");
                admin_first_name = Console.ReadLine();

                Console.WriteLine("admin_middle_name: ");
                admin_middle_name = Console.ReadLine();

                Console.WriteLine("admin_last_name: ");
                admin_last_name = Console.ReadLine();

                Console.WriteLine("admin_address: ");
                admin_address = Console.ReadLine();



                string prequery = "INSERT INTO accounts " +
                                  " VALUES('" + user_name + "', '" + password + "', '" + email + "', '" + role + "');" +
                                  " SELECT SCOPE_IDENTITY();";

                SqlCommand precommand = new SqlCommand(prequery, sqlconn);

                account_id = Convert.ToInt32(precommand.ExecuteScalar());
                //Console.WriteLine(account_id);
                Console.WriteLine("\n     1 account added.\n\n");



                string parametarizedQuery = "INSERT INTO " + "Admin  ";

                parametarizedQuery += " VALUES(@admin_id, @account_id, @admin_first_name," +
                                      " @admin_middle_name, @admin_last_name, @admin_address);";

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                sqlCommand.Parameters.AddWithValue("@admin_id", admin_id);
                sqlCommand.Parameters.AddWithValue("@account_id", account_id);
                sqlCommand.Parameters.AddWithValue("@admin_first_name", admin_first_name);
                sqlCommand.Parameters.AddWithValue("@admin_middle_name", admin_middle_name);
                sqlCommand.Parameters.AddWithValue("@admin_last_name", admin_last_name);
                sqlCommand.Parameters.AddWithValue("@admin_address", admin_address);

                Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Admin added.\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);

            }
        }

        public static void EditAdmin()
        {

            try
            {
                int account_id;
                string user_name;
                string password;
                string email;
                string role;

                string admin_id = "";
                string admin_first_name;
                string admin_middle_name;
                string admin_last_name;
                string admin_address;

                Console.WriteLine("editing an admin with his account");


                Console.WriteLine("admin_id: ");
                admin_id = Console.ReadLine();


                Console.WriteLine("user_name: ");
                user_name = Console.ReadLine();

                Console.WriteLine("password: ");
                password = Console.ReadLine();

                Console.WriteLine("email: ");
                email = Console.ReadLine();

                Console.WriteLine("role: ");
                role = Console.ReadLine();


                Console.WriteLine("admin_first_name: ");
                admin_first_name = Console.ReadLine();

                Console.WriteLine("admin_middle_name: ");
                admin_middle_name = Console.ReadLine();

                Console.WriteLine("admin_last_name: ");
                admin_last_name = Console.ReadLine();

                Console.WriteLine("admin_address: ");
                admin_address = Console.ReadLine();

                //string preprequery = "select account_id from "


                string preprequery = $"select account_id from Admin where admin_id = {admin_id}";
                SqlCommand preprecommand = new SqlCommand(preprequery, sqlconn);
                account_id = Convert.ToInt32(preprecommand.ExecuteScalar());
                //Console.WriteLine("--" + account_id + "--");

                string prequery = "update accounts " +
                                  $" set  user_name = '{user_name}',  password = '{password}',  email = '{email}', role = '{role}'" +
                                  $" where account_id = {account_id}";

                SqlCommand precommand = new SqlCommand(prequery, sqlconn);
                Console.WriteLine("\n    " + precommand.ExecuteNonQuery() + " account edited.\n\n");


                string parametarizedQuery = "update " + "Admin  ";
                parametarizedQuery += " set admin_first_name = @admin_first_name," +
                                     " admin_middle_name = @admin_middle_name, admin_last_name = @admin_last_name, admin_address = @admin_address";
                parametarizedQuery += " where admin_id = " + admin_id;

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);


                //sqlCommand.Parameters.AddWithValue("@department_id", department_id);
                sqlCommand.Parameters.AddWithValue("@admin_first_name", admin_first_name);
                sqlCommand.Parameters.AddWithValue("@admin_middle_name", admin_middle_name);
                sqlCommand.Parameters.AddWithValue("@admin_last_name", admin_last_name);
                //sqlCommand.Parameters.AddWithValue("@entry_year", entry_year);
                sqlCommand.Parameters.AddWithValue("@admin_address", admin_address);

                Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Admin edited.\n");

            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void DeleteAdmin()
        {


            try
            {
                int account_id;
                string admin_id = "";

                Console.WriteLine("Deleting an admin and his account");

                Console.WriteLine("admin_id: ");
                admin_id = Console.ReadLine();




                string preprequery = $"select account_id from Admin where admin_id = {admin_id}";
                SqlCommand preprecommand = new SqlCommand(preprequery, sqlconn);
                account_id = Convert.ToInt32(preprecommand.ExecuteScalar());
                //Console.WriteLine("--" + account_id + "--");

                string parametarizedQuery = "DELETE FROM " + "Admin " +
                                            " where admin_id = " + admin_id;

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);
                Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " admin deleted.\n");

                string prequery = "DELETE FROM accounts " +
                                 $" where account_id = {account_id}";

                SqlCommand precommand = new SqlCommand(prequery, sqlconn);
                Console.WriteLine("\n    " + precommand.ExecuteNonQuery() + " account deleted.\n\n");


            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void ShowAdminById()
        {
            try
            {
                string admin_id = "";

                Console.WriteLine("showing an admin by id");

                Console.WriteLine("admin_id: ");
                admin_id = Console.ReadLine();



                string parametarizedQuery = "SELECT * FROM " + "Admin, accounts " +
                                            " where accounts.account_id = Admin.account_id" +
                                            " and admin_id = " + admin_id;

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);
                //Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student deleted.\n");

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine();
                        Console.WriteLine("account_id: ........... " + reader[0]);
                        Console.WriteLine("User_name: ............ " + reader[1]);
                        Console.WriteLine("password: ............. " + reader[2]);
                        Console.WriteLine("email: ................ " + reader[3]);
                        Console.WriteLine("role: ................. " + reader[4]);
                        Console.WriteLine("admin_id: ............. " + reader[5]);
                        Console.WriteLine("admint_first_name: .... " + reader[6]);
                        Console.WriteLine("admin_middle_name: .... " + reader[7]);
                        Console.WriteLine("admin_last_name: ...... " + reader[8]);
                        Console.WriteLine("admin_address: ........ " + reader[9]);
                        Console.WriteLine("---------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("No registered Admin with such ID...");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }

        public static void ShowAllAdmins()
        {
            try
            {
                Console.WriteLine("showing all admins ");

                string parametarizedQuery = "SELECT * FROM " + "accounts, Admin " +
                                            " where accounts.account_id = Admin.account_id";

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);
                //Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student deleted.\n");

                int count = 1;
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Admin #" + count + ":");
                        Console.WriteLine("account_id: ........... " + reader[0]);
                        Console.WriteLine("User_name: ............ " + reader[1]);
                        Console.WriteLine("password: ............. " + reader[2]);
                        Console.WriteLine("email: ................ " + reader[3]);
                        Console.WriteLine("role: ................. " + reader[4]);
                        Console.WriteLine("admin_id: ............. " + reader[5]);
                        Console.WriteLine("admint_first_name: .... " + reader[6]);
                        Console.WriteLine("admin_middle_name: .... " + reader[7]);
                        Console.WriteLine("admin_last_name: ...... " + reader[8]);
                        Console.WriteLine("admin_address: ........ " + reader[9]);
                        Console.WriteLine("---------------------------------------");
                        count++;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
            }
        }


        public static void manage_users() //mahmoud
        {

            string choice = "";
            string op_choice = "";

            while (choice != "e")
            {

                Console.WriteLine("\n\nPease select from below: ");
                Console.WriteLine("1- Students ");
                Console.WriteLine("2- Staff members");
                Console.WriteLine("3- Admins ");
                Console.WriteLine("0- back ");
                Console.WriteLine("e- Exit app ");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    op_choice = "";

                    while (op_choice != "0")
                    {


                        Console.WriteLine("\nPlease select from below: ");
                        Console.WriteLine("1- add ");
                        Console.WriteLine("2- edit ");
                        Console.WriteLine("3- remove ");
                        Console.WriteLine("4- Show by id ");
                        Console.WriteLine("5- show all ");
                        Console.WriteLine("6- show filtered ");
                        Console.WriteLine("0- back ");
                        Console.WriteLine("e- Exit app ");

                        op_choice = Console.ReadLine();

                        if (op_choice == "1")
                        {
                            AddStudent();
                        }
                        else if (op_choice == "2")
                        {
                            EditStudent();
                        }
                        else if (op_choice == "3")
                        {
                            DeleteStudent();
                        }
                        else if (op_choice == "4")
                        {
                            ShowStudentById();
                        }
                        else if (op_choice == "5")
                        {
                            ShowAllStudents();
                        }
                        else if (op_choice == "6")
                        {
                            ShowAllSatisfying();
                        }
                        else if (op_choice == "0")
                        {
                            break;
                        }
                        else if (op_choice == "e")
                        {
                            CloseConnAndExit();
                        }
                    }
                }
                else if (choice == "2")
                {
                    op_choice = "";

                    while (op_choice != "0")
                    {


                        Console.WriteLine("\nPease select from below: ");
                        Console.WriteLine("1- add ");
                        Console.WriteLine("2- edit ");
                        Console.WriteLine("3- remove ");
                        Console.WriteLine("4- Show by id ");
                        Console.WriteLine("5- show all ");
                        Console.WriteLine("0- back ");
                        Console.WriteLine("e- Exit app ");

                        op_choice = Console.ReadLine();

                        if (op_choice == "1")
                        {
                            AddStaff();
                        }
                        else if (op_choice == "2")
                        {
                            EditStaff();
                        }
                        else if (op_choice == "3")
                        {
                            DeleteStaff();
                        }
                        else if (op_choice == "4")
                        {
                            ShowStaffById();
                        }
                        else if (op_choice == "5")
                        {
                            ShowAllStaff();
                        }
                        else if (op_choice == "0")
                        {
                            break;
                        }
                        else if (op_choice == "e")
                        {
                            CloseConnAndExit();
                        }
                    }
                }
                else if (choice == "3")
                {
                    op_choice = "";

                    while (op_choice != "0")
                    {


                        Console.WriteLine("\nPease select from below: ");
                        Console.WriteLine("1- add ");
                        Console.WriteLine("2- edit ");
                        Console.WriteLine("3- remove ");
                        Console.WriteLine("4- Show by id ");
                        Console.WriteLine("5- show all ");
                        Console.WriteLine("0- back ");
                        Console.WriteLine("e- Exit app ");

                        op_choice = Console.ReadLine();

                        if (op_choice == "1")
                        {
                            AddAdmin();
                        }
                        else if (op_choice == "2")
                        {
                            EditAdmin();
                        }
                        else if (op_choice == "3")
                        {
                            DeleteAdmin();
                        }
                        else if (op_choice == "4")
                        {
                            ShowAdminById();
                        }
                        else if (op_choice == "5")
                        {
                            ShowAllAdmins();
                        }
                        else if (op_choice == "0")
                        {
                            break;
                        }
                        else if (op_choice == "e")
                        {
                            CloseConnAndExit();
                        }
                    }
                }
                else if (choice == "0")
                {
                    break;
                }
                else if (choice == "e")
                {
                    CloseConnAndExit();
                }

                //student  
                // add                    DONE    addapt to identity change  DONE
                // edit                   DONE    set where condition right  DONE
                // remove                 DONE    set where condition right  DONE     also from table "account"   DONE 
                // show by id             DONE   
                // show all               DONE   
                // show all satisfying    DONE   
                //staff                          
                // add                    DONE   
                // edit                   DONE   
                // remove                 DONE   
                // show by id             DONE   
                // show all               DONE   
                //admin                          
                // add                    DONE    addapt to identity change  DONE
                // edit                   DONE    set where condition right  DONE
                // remove                 DONE    set where condition right  DONE     also from table "account"    DONE
                // show by id             DONE   
                // show all               DONE   
            }
        }



        static void Main(String[] args)
        {
            OpenConnTo("localhost", "faculty_management_system");
            //AddAdmin();
            //DeleteAdmin();


            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("| Hello and Welcome to our Faculty System App :)  |");
            Console.WriteLine("|                                                 |");
            Console.WriteLine("---------------------------------------------------" + "\n");


            while (true) // the program run
            {
                ////////////////////
                // welcome page ///
                //////////////////

                string option = "1";
                while (option != "e") // continue while invalid option
                {
                    Console.WriteLine("\nPlease Select an option to continue: " + "\n");
                    Console.WriteLine("1- sign in.");
                    Console.WriteLine("2- Sign up.");
                    Console.WriteLine("e- Exit.");
                    Console.Write("Enter your choise: ");
                    option = Console.ReadLine();
                    if (option == "1")
                    {
                        while (singedin_type == "")
                        {
                            signin();
                            if (singedin_type == "")
                            {
                                Console.WriteLine("0-exit\n1-try again\n");
                                Console.Write("yor choice: ");
                                int ch = int.Parse(Console.ReadLine());
                                if (ch == 0)
                                {
                                    CloseConnAndExit();
                                }
                            }

                        }
                        break;

                    }
                    else if (option == "2")
                    {
                        signup(); //required sign in as admin 
                        break;
                    }
                    else if (option == "e")
                    {
                        CloseConnAndExit();
                    }
                    else
                    {
                        Console.Write("\n invalid option.please,try agien.\n");
                    }
                }
                if (singedin_type == "admin") //admin page
                {
                    option = "1";
                    while (option != "e")
                    {
                        Console.WriteLine("\nPlease Select an option to continue: " + "\n");
                        Console.WriteLine("1- manage users.");
                        Console.WriteLine("2- manage departments.");
                        Console.WriteLine("3- manage courses .");
                        Console.WriteLine("0- back .");
                        Console.WriteLine("e- Exit.");
                        Console.Write("Enter your choise: ");
                        option = Console.ReadLine();
                        if (option == "1")
                        {
                            manage_users();
                        }
                        else if (option == "2")
                        {
                            manage_department();
                        }

                        else if (option == "3")
                        {
                            //manage courses // philo
                            manageCourses();

                        }
                        else if (option == "0")
                        {
                            break;
                        }
                        else if (option == "e")
                        {
                            CloseConnAndExit();
                        }
                        else
                        {
                            Console.Write("\n invalid option.please,try agien.\n");
                        }

                    }
                }
                else if (singedin_type == "student") //student page
                {
                    option = "1";
                    while (option != "e")
                    {
                        Console.WriteLine("\nPlease Select an option to continue: " + "\n");
                        Console.WriteLine("1- show profile.");
                        Console.WriteLine("2- show enrolling courses.");
                        Console.WriteLine("0- back");
                        Console.WriteLine("e- Exit.");
                        Console.Write("Enter your choise: ");
                        option = Console.ReadLine();
                        if (option == "1")
                        {
                            manage_profile();
                        }
                        else if (option == "2")
                        {
                            showEnrollingCourses();
                        }
                        else if (option == "0")
                        {
                            break;
                        }
                        else if (option == "e")
                        {
                            CloseConnAndExit();
                        }
                        else
                        {
                            Console.Write("\n invalid option.please,try agien.\n");
                        }
                    }

                }
            }





            /* while (choice != "7")
             {

                 //Console.WriteLine("Currently selected    -->   Database: " + g_Database + " | " + "Table: " + table + "\n");

                 Console.WriteLine("\nPlease Select an option to continue: " + "\n");

                 Console.WriteLine("1- sign up.");
                 Console.WriteLine("2- Sign in.");
                 Console.WriteLine("3- Show data");
                 Console.WriteLine("4- edit data");
                 Console.WriteLine("5- add course");
                 Console.WriteLine("6- add department");
                 Console.WriteLine("7- Exit the app");

                 Console.Write("Your option: ");
                 choice = Console.ReadLine();
                 Console.WriteLine("");
                 if (choice == "1")
                 {
                     signup();
                 }
                 else if (choice == "2")
                 {
                     signin();
                 }
                 else if (choice == "3")
                 {
                     if (singedin_type == "student")
                     {
                         show_student_data();
                     }
                     else if (singedin_type == "admin")
                     {
                         show_admin_data();
                     }
                     else
                     {
                         Console.WriteLine("sign in as a student or a admin first");
                     }
                 }
                 else if (choice == "4")
                 {
                     if (singedin_type == "student")
                     {
                         edit_student_data();
                     }
                     else if (singedin_type == "admin")
                     {
                         edit_admin_data();
                     }
                     else
                     {
                         Console.WriteLine("sign in as a student or a admin first");
                         Console.WriteLine("\n");
                     }
                 }
                 else if (choice == "5")
                 {
                     add_course();
                 }
                 else if (choice == "6")
                 {
                     add_department();
                 }
                 else if (choice == "7")
                 {
                     CloseConn();
                     Console.WriteLine("App closed, Thank you for using our App :)");
                 }
                 else
                 {
                     Console.WriteLine("Undefined command... Try again");
                 }



                 /*Console.WriteLine("Currently selected    -->   Database: " + g_Database + " | " + "Table: " + table + "\n");

                 Console.WriteLine("Please Select an option to continue: " + "\n");

                 Console.WriteLine("1- Connect to the Database.");
                 Console.WriteLine("2- Select a table from the database.");
                 Console.WriteLine("3- Insert a row into selected table");
                 Console.WriteLine("4- Update rows in the selected table");
                 Console.WriteLine("5- Delete rows from selected table table");
                 Console.WriteLine("6- Select / Project from current table");
                 Console.WriteLine("7- Exit the app");

                 Console.Write("Your option: ");
                 choice = Console.ReadLine();
                 Console.WriteLine("");
                 if (choice ==  "1")
                 {
                     OpenConnTo("localhost", "faculty_management_system");

                 }
                 else if(choice == "2")
                 {   
                     ReadTable();
                 }
                 else if (choice == "3")
                 {
                     ReadInput();
                     InsertRow();
                 }
                 else if (choice == "4")
                 {
                     Update();
                 }
                 else if (choice == "5")
                 {
                     DeleteFrom();
                 }
                 else if (choice == "6")
                 {
                     select();
                 }
                 else if (choice == "7")
                 {
                     CloseConn();
                     Console.WriteLine("App closed, Thank you for using our App :)");
                 }
                 else
                 {
                     Console.WriteLine("Undefined command... Try again");
                 }*/



        }

    }

}
