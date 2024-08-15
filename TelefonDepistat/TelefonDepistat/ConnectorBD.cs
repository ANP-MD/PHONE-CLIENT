using System;
using MySql.Data.MySqlClient;

namespace TelefonDepistat
{
    public class ConnectorBD
    {
        private string username; // Database username
        private string password; // Database password
        private string server;   // Database server IP or hostname
        private string database; // Database name
        private MySqlConnection connectionbd;
        private string connectionstring;

        // Constructor with username and password
        public ConnectorBD(string _username, string _password, string _server, string _database)
        {
            username = _username;
            password = _password;
            server = _server;
            database = _database;
            CreateConnectionBD();
        }

        // Constructor without username and password
        public ConnectorBD(string _server, string _database)
        {
            server = _server;
            database = _database;
        }

        private void CreateConnectionString()
        {
            // Create the MySQL connection string
            connectionstring = $"Server={server};Database={database};User ID={username};Password={password};";
        }

        public void SetUser(string _username)
        {
            username = _username;
        }

        public void SetPassword(string _password)
        {
            password = _password;
        }

        public string GetConnectionString()
        {
            return connectionstring;
        }

        public string CreateConnectionBD()
        {
            CreateConnectionString();
            try
            {
                connectionbd = new MySqlConnection(connectionstring);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "";
        }

        public MySqlConnection GetConnectionBD()
        {
            return connectionbd;
        }

        public string GetUser()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }
    }
}
