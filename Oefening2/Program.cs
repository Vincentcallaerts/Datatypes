using System;


namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            double prijs,totaal,btw;
            int aantal;
            
            btw = 1.21;

            Console.Write("Wat is de prijs van je drankje: ");
            prijs = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hoeveel drankjes wil je : ");
            aantal = Convert.ToInt32(Console.ReadLine());

            totaal = prijs * aantal;
            Console.WriteLine($"Prijs met btw: {totaal:F2} euro ");
            totaal = Math.Round(totaal * btw,2);
            Console.WriteLine($"Prijs zonder btw: {totaal:F2} euro ");
            Console.ReadLine();
            
        }
    }
}
