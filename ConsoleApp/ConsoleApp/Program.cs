using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {


            Console.WriteLine("Erste Zahl");
            int a;

            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Das ist keine Zahl!");
                return;
            }

            Console.WriteLine("Zweite Zahl");
            int b;

            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Das ist keine Zahl!");
                return;
            }

            if (a > b)
            {
                Console.WriteLine($"{a} ist groesser als {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"{b} ist groesser als {a}");// твой код
            }
            else
            {
                Console.WriteLine($"{a} ist gleich {b}");// твой код для равенства
            }






            Console.ReadLine();

        }



            
            
        
    }
}