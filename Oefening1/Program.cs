using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, oplossing1, oplossing2;
            double oplossing3,oplossing4, oplossing5, oplossing6;

            Console.Write("Wat is je eerste getal: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wat is je tweede getal: ");
            getal2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(getal1 + " + " + getal2 + " = " + (oplossing1 = getal1 + getal2));
            Console.WriteLine(getal1 + " - " + getal2 + " = " + (oplossing2 = getal1 - getal2));
            Console.WriteLine(getal1 + " * " + getal2 + " = " + (oplossing3 = getal1 * getal2));
            Console.WriteLine(getal1 + " / " + getal2 + " = " + (oplossing4 = Convert.ToDouble(getal1) / getal2));

            oplossing5 = oplossing1 + oplossing2 + oplossing3 + oplossing4;
            oplossing6 = oplossing1 * oplossing2 * oplossing3 * oplossing4;

            Console.WriteLine($"{oplossing1} + {oplossing2} + {oplossing3} + {oplossing4} = {Math.Round(oplossing5, 2)}");
            Console.WriteLine($"{oplossing1} * {oplossing2} * {oplossing3} * {oplossing4} = {Math.Round(oplossing6,2)}");

            Console.ReadLine();
        }
    }
}
