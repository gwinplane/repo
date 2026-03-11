using AddressManagementSystem.Data;
using AddressManagementSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace AddressManagementSystem.Services
{
    public class AddressService
    {
        private readonly Database _db;

        public AddressService()
        {
            _db = new Database();
        }

        // ======================
        // CREATE
        // ======================
        public bool AddAddress(Address address)
        {


            //--------------------------------

     /*       public bool AddAddress(Address address)
        {
            // 🔍 ШАГ 1: Проверяем существование
            if (AddressExists(address.Street, address.HouseNumber))
            {
                Console.WriteLine("❌ Адрес уже существует!");
                return false;  // Прерываем! Не пытаемся вставить
            }

            // ✅ ШАГ 2: Вставляем (только если проверка прошла)
            try
            {
                using var conn = _db.GetConnection();
                conn.Open();

                string query = @"INSERT INTO addresses ...";
                var cmd = new MySqlCommand(query, conn);
                // параметры...

                cmd.ExecuteNonQuery();  // Вставка

                return true;  // Успех!
            }
            catch (MySqlException ex)  // Ловим ДРУГИЕ ошибки (не дубликаты)
            {
                Console.WriteLine($"❌ Ошибка БД: {ex.Message}");
                return false;
            }
        }

        // Метод проверки
        public bool AddressExists(string street, string houseNumber)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            // SQL: Подсчитываем количество адресов с такими street + house_number
            string query = "SELECT COUNT(*) FROM addresses WHERE street = @street AND house_number = @house";
            var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@street", street);
            cmd.Parameters.AddWithValue("@house", houseNumber);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count > 0;  // true = существует, false = не существует
        }*/

            //--------------------------------
            

            try
            {
                using var conn = _db.GetConnection();
                conn.Open();

                string query = @"INSERT INTO addresses
                    (street, house_number, postal_code, city, country)
                    VALUES (@street, @house, @postal, @city, @country)";

                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@street", address.Street);
                cmd.Parameters.AddWithValue("@house", address.HouseNumber);
                cmd.Parameters.AddWithValue("@postal", address.PostalCode);
                cmd.Parameters.AddWithValue("@city", address.City);
                cmd.Parameters.AddWithValue("@country", address.Country);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex) when (ex.Number == 1062) //попробув выполнить этот код, если ошибка, то
            {
                Console.WriteLine($"Error: Address ({address.Street}, {address.HouseNumber}) alredy exist!");
                return false; //не добавлено дубликат
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
                return false; //не добавлено (другая ошибка БД)
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false; //Не добавлено (другая ошибка)
            }
        }

        // ======================
        // READ
        // ======================
        public List<Address> GetAllAddresses()
        {
            var addresses = new List<Address>();

            using var conn = _db.GetConnection();
            conn.Open();

            string query = "SELECT * FROM addresses";
            var cmd = new MySqlCommand(query, conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                addresses.Add(new Address
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Street = reader["street"].ToString(),
                    HouseNumber = reader["house_number"].ToString(),
                    PostalCode = reader["postal_code"].ToString(),
                    City = reader["city"].ToString(),
                    Country = reader["country"].ToString()
                });
            }

            return addresses;
        }

        // ======================
        // DELETE
        // ======================
        public void DeleteAddress(int id)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            string query = "DELETE FROM addresses WHERE id = @id";
            var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
