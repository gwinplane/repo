using AddressManagementSystem.Data;
using AddressManagementSystem.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressManagementSystem.Services
{

    //Base strukture
    public class AddressService
    {
        private readonly Database _db;

        public AddressService()
        {
            _db = new Database(); // объект для получения соединения
        }

        // CREATE
        public void AddAddress(Address address)
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
        }

        // READ
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
                    Id = (int)reader["id"],
                    Street = reader["street"].ToString(),
                    HouseNumber = reader["house_number"].ToString(),
                    PostalCode = reader["postal_code"].ToString(),
                    City = reader["city"].ToString(),
                    Country = reader["country"].ToString()
                });
            }

            return addresses;
        }
    }
}
