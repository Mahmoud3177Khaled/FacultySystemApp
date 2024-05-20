//using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FacultySystemApp
{
    public static class DatabaseManager
    {
        private static SqlConnection _connection;

        public static SqlConnection Connection => _connection;

        public static void OpenConnection(string connectionString)
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(connectionString);
            }

            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public static void CloseConnection()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}