namespace FacultySystemApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "Server= localhost; Database= faculty_management_system; Integrated Security= True;";

            DatabaseManager.OpenConnection(connectionString);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomeForm());
            DatabaseManager.CloseConnection();
        }
    }
}