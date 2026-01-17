using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Name des Helden");
            string name = Console.ReadLine();
            Console.WriteLine($"Hallo, {name}!");

            Console.WriteLine("Magischer Gegenstand");
            string gegenstand = Console.ReadLine();
            Console.WriteLine($"Dein Gegenstand ist {gegenstand}!");

            Console.WriteLine("Was ist dein Ort?");
            string ort = Console.ReadLine();
            Console.WriteLine($"Dein Ort ist {ort}!");

      
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("=== DEIN FRAGEBOGEN ===");
            Console.WriteLine($"Name des Helden: {name}");
            Console.WriteLine();
            Console.WriteLine($"Magischer Gegenstand: {gegenstand}");
            Console.WriteLine();
            Console.WriteLine($"Ort: {ort}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Eines Tages fand {name} einen {gegenstand}.");
            Console.WriteLine($"Mit diesem Gegenstand ging er zum {ort}.");
            Console.WriteLine($"Dort begann ein unglaubliches Abenteuer!");


            Console.ReadLine();
        }
    }
}