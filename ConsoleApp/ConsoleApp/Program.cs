using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Betrag in EUR:");

            double eur;
            if (!double.TryParse(Console.ReadLine(), out eur))
            {
                Console.WriteLine("Das ist keine Zahl!");
                return;
            }

            double kurs = 1.10;
            double usd = eur * kurs;

            Console.WriteLine($"{eur} EUR = {usd} USD");
            Console.WriteLine($"{eur} EUR = {Math.Round(usd, 2)} USD");
            
            Console.WriteLine();
            Console.WriteLine("Oder umgekehrt:");
            Console.WriteLine("Betrag in USD:");
            double usd2 = double.Parse(Console.ReadLine());

            double eur2 = usd2 / kurs;
            Console.WriteLine($"{usd2} USD = {eur2} EUR");
            Console.WriteLine($"{usd2} USD = {Math.Round(eur2, 2)} EUR");



            Console.ReadLine();

        }



            
            
        
    }
}