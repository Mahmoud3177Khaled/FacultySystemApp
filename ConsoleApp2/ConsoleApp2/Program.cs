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
            Console.WriteLine("1- Student \n2- admin");
            user = Console.ReadLine();

            if (user == "1")
            {
                try
                {

                    Console.WriteLine("adding student");

                    Console.WriteLine("email: ");
                    email = Console.ReadLine();

                    Console.WriteLine("password: ");
                    password = Console.ReadLine();

                    Console.WriteLine("username: ");
                    username = Console.ReadLine();

                    Console.WriteLine("student_id: ");
                    student_id = Console.ReadLine();


                    string prequery = "INSERT INTO student VALUES(" + student_id + ", 1, 1, 1, 1, 1);";  //will be edited later
                    SqlCommand precommand = new SqlCommand(prequery, sqlconn);
                    Console.WriteLine("\n    " + precommand.ExecuteNonQuery() + " student added.\n\n");

                    string parametarizedQuery = "INSERT INTO " + "student_account";

                    parametarizedQuery += " VALUES(@email, @password, @username, @student_id);";

                    SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                    //sqlCommand.Parameters.AddWithValue("@table", table);
                    sqlCommand.Parameters.AddWithValue("@email", email);
                    sqlCommand.Parameters.AddWithValue("@password", password);
                    sqlCommand.Parameters.AddWithValue("@username", username);
                    sqlCommand.Parameters.AddWithValue("@student_id", student_id);

                    Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " Student_account added.\n\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("error: " + e.Message);
                }

            }
            else if (user == "2")
            {
                try
                {
                    Console.WriteLine("adding admin");


                    Console.WriteLine("admin_id: ");
                    admin_id = Console.ReadLine();

                    Console.WriteLine("first_name: ");
                    first_name = Console.ReadLine();

                    Console.WriteLine("middle_name: ");
                    middle_name = Console.ReadLine();

                    Console.WriteLine("last_name: ");
                    last_name = Console.ReadLine();

                    Console.WriteLine("admin_address: ");
                    admin_address = Console.ReadLine();


                    string parametarizedQuery = "INSERT INTO " + "Admin_data";

                    parametarizedQuery += " VALUES(@admin_id, @first_name, @middle_name, @last_name, @admin_address);";

                    SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                    //sqlCommand.Parameters.AddWithValue("@table", table);
                    sqlCommand.Parameters.AddWithValue("@admin_id", admin_id);
                    sqlCommand.Parameters.AddWithValue("@first_name", first_name);
                    sqlCommand.Parameters.AddWithValue("@middle_name", middle_name);
                    sqlCommand.Parameters.AddWithValue("@last_name", last_name);
                    sqlCommand.Parameters.AddWithValue("@admin_address", admin_address);

                    Console.WriteLine("\n    " + sqlCommand.ExecuteNonQuery() + " admin added.\n\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("error: " + e.Message);
                }

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

            string check_query = $"SELECT role FROM accounts WHERE email = '{email}' AND password='{password}'";
            try
            {
                SqlCommand sc = new SqlCommand(check_query, sqlconn);

                using (SqlDataReader reader = sc.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        singedin_type = "" + reader[0];
                        //Console.WriteLine(singedin_type);
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
        public static void manageCourses(){

            Console.WriteLine("             ------------------");
            Console.WriteLine("            |                   |");
            Console.WriteLine("            |      courses      |");
            Console.WriteLine("            |                   |");
            Console.WriteLine("             ------------------" + "\n");
            Console.WriteLine("1-show courses\n2-create course\n3-edit course\n4-delete course\n5-enrollig student in courses\n ");
            Console.WriteLine("your choice: ");
            string ch = Console.ReadLine();
            if(ch == "1"){

            }
            else if(ch == "2"){
                createCourse();
            }
            else if(ch == "3"){

            }
            else if(ch == "4"){

            }
            else if(ch == "5"){

            }
            else if(ch == ""){

            }

            
        }
        public static void createCourse(){

            Console.WriteLine("             ----------------------");
            Console.WriteLine("            |                       |");
            Console.WriteLine("            |    create new course  |");
            Console.WriteLine("            |                       |");
            Console.WriteLine("             -----------------------" + "\n\n");
            Console.WriteLine("course id");
            int courseId = int.Parse(Console.ReadLine());
            Console.WriteLine("department id");
            string departmentId = Console.ReadLine();
            Console.WriteLine("course name");
            string courseName = Console.ReadLine();
            Console.WriteLine("credit hours");
            int creditHours = int.Parse(Console.ReadLine());

            string addQuery = $"INSERT INTO course VALUES "
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
                string department_Id;
                string department_name;


                Console.WriteLine("adding department");

                Console.WriteLine("department_Id: ");
                department_Id = Console.ReadLine();

                Console.WriteLine("department_name: ");
                department_name = Console.ReadLine();


                string parametarizedQuery = "INSERT INTO " + "department";

                parametarizedQuery += " VALUES(@department_Id, @department_name);";

                SqlCommand sqlCommand = new SqlCommand(parametarizedQuery, sqlconn);

                //sqlCommand.Parameters.AddWithValue("@table", table);
                sqlCommand.Parameters.AddWithValue("@department_Id", department_Id);
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

        public static void manage_users() //mahmoud
        {
            //student  
            // add
            //edit
            //remove   from table account and table studend
            //show 
            //show all
            //staff  
            // add
            //edit
            //remove
            //show
            //admin  
            // add
            //edit
            //remove
            //show 
        }

        static void Main(String[] args)
        {
            OpenConnTo("localhost", "faculty_management_system1");

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
                            signin(); //philo
                            if(singedin_type == ""){
                                Console.WriteLine("\n0-exit\n1-try again\n");
                                Console.Write("yor choice: ");
                                int ch = int.Parse(Console.ReadLine());
                                if (ch == 0){
                                    break;
                                }
                            }
                            
                        }
                        break;
                    }
                    else if (option == "2")
                    {
                        signup(); //required sign in as admin //george
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
                        Console.WriteLine("e- Exit.");
                        Console.Write("Enter your choise: ");
                        option = Console.ReadLine();
                        if (option == "1")
                        {
                            manage_users();
                        }
                        else if (option == "2")
                        {
                            // manage department //george
                        }

                        else if (option == "3")
                        {
                            //manage courses // philo
                            manageCourses();
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
                            //profile --> george
                        }
                        else if (option == "2")
                        {
                            //show -->philo
                        }
                        else if (option == "0")
                        {
                            //-----> go to welcome page
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
