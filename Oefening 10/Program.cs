using System;


namespace Oefening_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 0, getal2 = 1, getal3, i, number;

            Console.Write("Hoeveel lang wil je je fibonacci rij : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(getal1 + " " + getal2 + " ");

            for (i = 2; i < number; ++i)
            {
                getal3 = getal1 + getal2;
                Console.Write(getal3 + " ");
                getal1 = getal2;
                getal2 = getal3;
            }

            Console.ReadLine();
        }
    }
}