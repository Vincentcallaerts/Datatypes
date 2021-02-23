using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening5
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1, getal2;

            Console.Write("getal 1 :");
            getal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("getal 2 :");
            getal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Als je {getal1} deelt door {getal2}, dan is de rest {getal1%getal2}");
            Console.ReadLine();
        }
    }
}
