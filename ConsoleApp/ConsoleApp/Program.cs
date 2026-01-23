using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {


            Console.WriteLine("Gib eine Zahl ein");
            int zahl = int.Parse(Console.ReadLine());

                    if (zahl > 0)
                    {
                        Console.WriteLine($"Positive Zahl");

                    }


                    else if (zahl < 0) 
                    {
                        Console.WriteLine($"Negative Zahl");
                    }

                    else 
                    {
                        Console.WriteLine($"Null");
                    }





                    Console.ReadLine();

        }



            
            
        
    }
}