using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Gewicht (kg):");
            double gewicht;
            if (!double.TryParse(Console.ReadLine(), out gewicht))
            {
                Console.WriteLine("Das ist keine Zahl!");
                return;
            }

            Console.WriteLine("Groesse (m):");
            double groesse;
            if (!double.TryParse(Console.ReadLine(), out groesse))
            {
                Console.WriteLine("Das ist keine Zahl!");
                return;
            }

            double bmi = gewicht / (groesse * groesse);

            Console.WriteLine();
            Console.WriteLine($"Dein BMI: {Math.Round(bmi, 2)}");
            


            Console.ReadLine();

        }



            
            
        
    }
}