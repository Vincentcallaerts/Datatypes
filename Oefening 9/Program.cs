using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double afstand, snelheid, tijdsduur;

            Console.Write("Af te leggen afstand in km: ");
            afstand = Convert.ToDouble(Console.ReadLine());
            Console.Write("Snelheid in km/h: ");
            snelheid = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            tijdsduur = afstand/snelheid;
          

            Console.WriteLine($"De vrachtwagen zal nog {tijdsduur} uur moeten rijden.");
           
            Console.ReadLine();
        }
    }
}
