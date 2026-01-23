using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Preis pro Stück:");
            double preis;
            if (!double.TryParse(Console.ReadLine(), out preis))
            {
                Console.WriteLine("Das ist keine Zahl!");
                return;
            }

            Console.WriteLine("Anzahl:");
            int anzahl;
            if (!int.TryParse(Console.ReadLine(), out anzahl))
            {
                Console.WriteLine("Das ist keine Zahl!");
                return;
            }

            double summe = preis * anzahl;
            double steuer = summe * 0.19;      // 19% налог
            double gesamt = summe + steuer;    // Общая сумма

            Console.WriteLine();
            Console.WriteLine($"Summe: {Math.Round(summe, 2)} EUR");
            Console.WriteLine($"Steuer (19%): {Math.Round(steuer, 2)} EUR");
            Console.WriteLine($"Gesamt: {Math.Round(gesamt, 2)} EUR");


            Console.ReadLine();

        }



            
            
        
    }
}