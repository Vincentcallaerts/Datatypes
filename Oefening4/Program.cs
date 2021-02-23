using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam, voornaam, volledigenaam, adres, postcode, hobbie;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Geef je voornaam in: ");
            Console.ForegroundColor = ConsoleColor.Green;
            voornaam = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Geef je naam in: ");
            Console.ForegroundColor = ConsoleColor.Green;
            naam = Console.ReadLine();

            volledigenaam = voornaam + " " + naam;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Geef je Straatnaam en huisnummer in: ");
            Console.ForegroundColor = ConsoleColor.Green;
            adres = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Geef je postcode in: ");
            Console.ForegroundColor = ConsoleColor.Green;
            postcode = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Geef je hobbie in: ");
            Console.ForegroundColor = ConsoleColor.Green;
            hobbie = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine($"Dag: {volledigenaam}! Jij woont op {adres}, {postcode}. {Environment.NewLine}jouw hobby is {hobbie}");
            

            Console.ReadLine();
        }
    }
}
