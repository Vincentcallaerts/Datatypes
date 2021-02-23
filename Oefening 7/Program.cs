using System;


namespace Oefening_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, getal3;

            Console.Write("Getal 1: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 2: ");
            getal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 3: ");
            getal3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"{getal1} - {getal2} - {getal3}");
            Console.WriteLine($"{getal1} - {getal3} - {getal2}");
            Console.WriteLine($"{getal2} - {getal1} - {getal3}");
            Console.WriteLine($"{getal2} - {getal3} - {getal1}");
            Console.WriteLine($"{getal3} - {getal2} - {getal1}");
            Console.WriteLine($"{getal3} - {getal1} - {getal2}");

            Console.ReadLine();
        }
    }
}
