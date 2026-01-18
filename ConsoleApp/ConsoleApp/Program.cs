using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Gib die erste Zahl ein:");
            int zahl1;
            bool ok1 = int.TryParse(Console.ReadLine(), out zahl1);

            if (ok1)
            {
                Console.WriteLine($"Sie haben {zahl1} eingegeben");
            }
            else
            {
                Console.WriteLine("Das ist nicht Zahl!");
            }
            Console.WriteLine("Gib die zweite Zahl ein:");
            int zahl2;
            bool ok2 = int.TryParse(Console.ReadLine(), out zahl2);

            if (ok2)
            {
                Console.WriteLine($"Sie haben {zahl2} eingegeben");
            }
            else
            {
                Console.WriteLine("Das ist nicht Zahl!");
            }
            
            Console.WriteLine("=== ERGEBNISSE ===");
            Console.WriteLine($"{zahl1} + {zahl2} = {zahl1+ zahl2}");
            


            Console.ReadLine();
        }
    }
}