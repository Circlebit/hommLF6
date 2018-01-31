using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anfangskapital: ");
            double anfangskapital = Convert.ToDouble(Console.ReadLine());
            Console.Write("Zinssatz in %: ");
            double zinssatz = Convert.ToDouble(Console.ReadLine());

            double kapital = anfangskapital;
            int jahr = 1;

            while(kapital < anfangskapital*2)
            {
                kapital += kapital * (zinssatz/100);
                Console.WriteLine($"Jahr: {jahr} \t Kapital: {kapital}");
                jahr++;
            }
            Console.WriteLine($"Laufzeit: {jahr-1} Jahre");
        }
    }
}
