using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie bitte eine Zahl ein:");
            int zahl = int.Parse(Console.ReadLine());
            int rest = zahl % 2;
            Console.WriteLine($"{zahl} % 2 = {rest}");
            if (rest == 0)
            {
                Console.WriteLine("(Die Zahl ist gerade)");
            }
            else
            {
                Console.WriteLine("Die Zahl ist ungerade");
            }



            Console.ReadLine();
        }
    }
}