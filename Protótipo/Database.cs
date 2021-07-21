using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Propet
{
    class Database
    {
        private static MySqlConnection connection;
        private static Database instance;
        private const string URL = "Server=localhost;Database=propet;Uid=root;Pwd=admin;";
        private Database()
        {
            connection = new MySqlConnection(URL);
        }
        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        public void ExecuteSQL(string qry)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            MySqlCommand comm = new MySqlCommand(qry, connection);
            comm.ExecuteNonQuery();
            connection.Close();
        }

    }
}
