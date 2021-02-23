using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal;

            Console.Write("Getal: ");
            getal = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{getal} x {i+1} = {getal * (i+1)}");
            }

            Console.ReadLine();
        }
    }
}
