using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {


            Console.WriteLine("Erste Zahl:");
            double a;

            if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Das ist keine Zahl!");
                    return;
                }
            Console.WriteLine("Zweite Zahl:");

            double b;

            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Das ist keine Zahl!");
                return;
            }

            Console.WriteLine("Waehlen Sie die Operation ein:");
            string op = Console.ReadLine();



            if (op == "+") 
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
            else if (op == "-")
            {
                Console.WriteLine($"{a} - {b} = {a - b}");// твой код
            }
            else if (op == "*")
            {
                Console.WriteLine($"{a} * {b} = {a * b}");// твой код
            }
            else if (op == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("Fehler: Division durch Null!");
                }
                else
                {
                    Console.WriteLine($"{a} / {b} = {a / b}");
                }
            }
            else
            {
                Console.WriteLine("Unbekannte Operation!");
            }








            Console.ReadLine();

        }



            
            
        
    }
}