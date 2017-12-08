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

            Console.Write("Zinswert p: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Laufzeit n (in Jahren): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("| Laufzeit \t| Zinsen im lfd. Jahr \t| Gesamtkapital \t|");
            for (int line = 1; line <= n; line++)
            {
                Console.WriteLine($"| {n} \t| \t| \t|");
            }

        }
    }
}
