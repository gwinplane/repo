using AddressManagementSystem.Data;
using AddressManagementSystem.Models;
using AddressManagementSystem.Services;
using MySql.Data.MySqlClient;
using System;

namespace AddressManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressService service = new AddressService();

            while (true)
            {
                Console.WriteLine("1. Add address");
                Console.WriteLine("2. View all addresses");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Street: ");
                    string street = Console.ReadLine();

                    Console.Write("House Number: ");
                    string houseNumber = Console.ReadLine();

                    Console.Write("Postal Code: ");
                    string postalCode = Console.ReadLine();

                    Console.Write("City: ");
                    string city = Console.ReadLine();

                    Console.Write("Country: ");
                    string country = Console.ReadLine();

                    var address = new Address
                    {
                        Street = street,
                        HouseNumber = houseNumber,
                        PostalCode = postalCode,
                        City = city,
                        Country = country
                    };

                    service.AddAddress(address);
                    Console.WriteLine("Address added!\n");
                }
                else if (choice == "2")
                {
                    var addresses = service.GetAllAddresses();
                    foreach (var addr in addresses)
                    {
                        Console.WriteLine($"{addr.Id}: {addr.Street}, {addr.HouseNumber}, {addr.PostalCode}, {addr.City}, {addr.Country}");
                    }
                    Console.WriteLine();
                }
                else if (choice == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.\n");
                }
            }
        }
    }
}