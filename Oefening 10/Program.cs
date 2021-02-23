using System;


namespace Oefening_10
{
    class Program
    {
        static void Main(string[] args)
        {

            int nummer;
            Console.Write("Hoeveel lang wil je je fibonacci rij : ");
            nummer = Convert.ToInt32(Console.ReadLine());

            /* Normal loop
            int getal1 = 0, getal2 = 1, getal3,
            Console.Write(getal1 + " " + getal2 + " ");
            for (i = 2; i < nummer; ++i)
            {
                getal3 = getal1 + getal2;
                Console.Write(getal3 + " ");
                getal1 = getal2;
                getal2 = getal3;
            }
            */

            void fibo(int eerstegetal, int tweedegetal, int teller, int lengte)
            {

                if (teller <= lengte)
                {
                    Console.Write(eerstegetal + " ");
                    fibo(tweedegetal, eerstegetal + tweedegetal, teller+1, lengte);
                }
                

            }

            fibo(0,1,1,nummer);
            
            Console.ReadLine();
        }
    }
}