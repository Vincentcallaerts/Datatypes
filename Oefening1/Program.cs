using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double getal1, getal2, oplossing1, oplossing2, oplossing3, oplossing4, oplossing5, oplossing6;

            Console.Write("Wat is je eerste getal: ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wat is je tweede getal: ");
            getal2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(getal1 + " + " + getal2 + " = " + (oplossing1 = getal1 + getal2));
            Console.WriteLine(getal1 + " - " + getal2 + " = " + (oplossing2 = getal1 - getal2));
            Console.WriteLine(getal1 + " * " + getal2 + " = " + (oplossing3 = getal1 * getal2));
            Console.WriteLine(getal1 + " / " + getal2 + " = " + (oplossing4 = getal1 / getal2));

            oplossing5 = oplossing1 + oplossing2 + oplossing3 + oplossing4;
            oplossing6 = oplossing1 * oplossing2 * oplossing3 * oplossing4;
            
            Console.WriteLine();
            Console.WriteLine($"{oplossing1} + {oplossing2} + {oplossing3} + {oplossing4} = {oplossing5.ToString("0.##")}");
            Console.WriteLine($"{oplossing1} * {oplossing2} * {oplossing3} * {oplossing4} = {oplossing6.ToString("0.##")}");

            Console.ReadLine();
        }
    }
}
