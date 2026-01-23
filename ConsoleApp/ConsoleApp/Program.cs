using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {


            Console.WriteLine("Wie alt bist du?");

            int age = int.Parse(Console.ReadLine());

            if (age < 12)
            {
                Console.WriteLine("Du bist ein Kind");
            }
            else if (age >= 12 && age <= 17)
            {
                Console.WriteLine("Du bist ein Jugendlicher");// твой код
            }
            else if (age >= 18 && age <= 64)
            {
                Console.WriteLine("Du bist ein Erwachsener");// твой код
            }
            else (age >= 65)
            {
                Console.WriteLine("Du bist ein Rentner");// твой код
            }




            Console.ReadLine();

        }



            
            
        
    }
}