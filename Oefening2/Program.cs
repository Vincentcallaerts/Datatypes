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

            totaal = Math.Round(prijs * aantal,2);
            Console.WriteLine($"Prijs met btw: {totaal} euro ");
            totaal = Math.Round(totaal * btw,2);
            Console.WriteLine($"Prijs zonder btw: {totaal} euro ");
            Console.ReadLine();
        }
    }
}
