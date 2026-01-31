using System;
using MySql.Data.MySqlClient;
namespace AddressManagementSystem.Data
{
    public class Database
    {
        private string connectionString =
            "server=localhost;database=address_db;user=root;password=;"; //подключаемся к базе данных
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}