using System;


namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            double far, cel;

            Console.Write("Hoeveel grade Fahrenheit is het momenteel: ");
            far = Convert.ToDouble(Console.ReadLine());
            cel = Math.Round((far - 32) / 1.8);
            Console.WriteLine($"Het is momenteel {cel} Celcius ");
            Console.ReadLine();
        }
    }
}
