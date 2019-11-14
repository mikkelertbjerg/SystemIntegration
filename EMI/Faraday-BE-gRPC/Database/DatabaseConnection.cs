using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faraday_BE_gRPC.Database
{
    public class DatabaseConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        public DatabaseConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "server"; //Fields are given dummy values.
            database = "database"; //Fields are given dummy values.
            user = "user"; //Fields are given dummy values.
            password = "password"; //Fields are given dummy values.
            string connectionString;
            connectionString = $"Server={server};Database={database};Uid={user};Pwd={password}";
        }

        public static string GetConnectionString()
        {
            string server = "server"; //Fields are given dummy values.
            string database = "database"; //Fields are given dummy values.
            string user = "user"; //Fields are given dummy values.
            string password = "password"; //Fields are given dummy values.
            string connectionString;
            return connectionString = "Server=" + server + ";" + "Database=" + database + ";" +
                "Uid=" + user + ";" + "Pwd=" + password + ";";
        }

        public bool OpenConnection()
        {
            connection.Open();
            return true;
        }

        public bool CloseConnection()
        {
            connection.Close();
            return true;
        }
    }
}
