using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anfangskapital ak: ");
            double ak = Convert.ToDouble(Console.ReadLine());

            Console.Write("Zinswert p (in Prozent): ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Laufzeit n (in Jahren): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double zinsLastYear = 0;
            double zinsThisYear = ak * (p / 100);
            double gesamtKapital = ak;

            // unfertig!
            Console.WriteLine("\n\r| Laufzeit | Zinsen im lfd. Jahr | Gesamtkapital |");
            for (int line = 1; line <= n; line++)
            {
                zinsLastYear = zinsThisYear;
                zinsThisYear = zinsLastYear + zinsThisYear * (p/100);
                gesamtKapital = gesamtKapital + zinsThisYear;

                Console.Write($"| {line}\t   | {zinsThisYear} \t\t\t | {gesamtKapital}  \t|\n\r");
            }

        }

    }
}
