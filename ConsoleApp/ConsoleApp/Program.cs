using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {


            Console.WriteLine("Geben Sie die Punkte ein:");
            int punkte;

            if (!int.TryParse(Console.ReadLine(), out punkte))
                {
                    Console.WriteLine("Das ist keine Zahl!");
                    return;
                }



            if (punkte >= 90)
            {
                Console.WriteLine("Note: Sehr gut (1)");
            }
            else if (punkte >= 75)
            {
                Console.WriteLine("Note: Gut (2)");
            }
            else if (punkte >= 60)
            {
                Console.WriteLine("Note: Befriedigend (3)");
            }
            else if (punkte >= 50)
            {
                Console.WriteLine("Note: Ausreichend (4)");
            }
            else
                {
                    Console.WriteLine("Note: Nicht bestanden (5)");
                }






            Console.ReadLine();

        }



            
            
        
    }
}