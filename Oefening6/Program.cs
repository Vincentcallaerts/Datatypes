using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantalv, aantalt, aantalk;
            double totaal, korting;

            Console.WriteLine("Welkom in plopsaland!!");

            Console.Write("Met hoeveel volwassenen zijn jullie: ");
            aantalv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Met hoeveel tieners zijn jullie: ");
            aantalt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Met hoeveel kinderen zijn jullie: ");
            aantalk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Prijs per volwassenen: 35 euro{Environment.NewLine}Prijs per tiener: 25 euro{Environment.NewLine}Prijs per kind: 20 euro");
            Console.WriteLine("Promotie: per extra ticket van diezelfde leeftijdsgroep 10% korting");
            Console.WriteLine();

            totaal = 35 * aantalv + 25 * aantalt + 20 * aantalk;
            Console.WriteLine($"Totaal: {totaal} ");

            if (totaal >= 200)
            {
                totaal = totaal - totaal * 0.1;
                Console.WriteLine($"Totaal na korting: {totaal} ");
            }

            Console.ReadLine();

        }
    }
}
