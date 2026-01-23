using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {


            Console.WriteLine("Gib eine Zahl ein");
            int zahl = int.Parse(Console.ReadLine());

            if (zahl % 2 == 0)
            {
                Console.WriteLine($"Die Zahl {zahl} ist gerade");
            }
            else
            {
                Console.WriteLine($"Die Zahl {zahl} ist ungerade");// твой код
                Console.WriteLine($"Die Zahl {zahl} ist ungerade");// твой код
            }




            Console.ReadLine();

        }



            
            
        
    }
}