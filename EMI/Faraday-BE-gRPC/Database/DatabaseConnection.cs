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
            server = "mysql50.unoeuro.com";
            database = "mikkelertbjerg_dk_db_ls";
            user = "mikkelertbjerg_dk";
            password = "knockers2019";
            string connectionString;
            connectionString = $"Server={server};Database={database};Uid={user};Pwd={password}";
        }

        public static string GetConnectionString()
        {
            string server = "mysql50.unoeuro.com";
            string database = "mikkelertbjerg_dk_db_ls";
            string user = "mikkelertbjerg_dk";
            string password = "knockers2019";
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
