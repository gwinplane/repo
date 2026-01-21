using System;


namespace Lessons
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Note1:");
            double note1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Note2:");
            double note2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Note3:");
            double note3 = double.Parse(Console.ReadLine());

            //double durchschnitt = (note1 + note2 + note3) / 3;
            //Console.WriteLine($"Durchschnitt: {durchschnitt}");

            //Console.WriteLine($"Durchschnitt: {(note1+note2+note3)/3}");
            Console.WriteLine($"Durchschnitt: {Math.Round((note1 + note2 + note3) / 3, 2)}");



            Console.ReadLine();
        }
    }
}