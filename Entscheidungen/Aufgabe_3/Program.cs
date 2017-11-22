using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double gehalt;
            double erhoehung;

            Console.Write("Gehalt: ");
            gehalt = Convert.ToDouble(Console.ReadLine());

            erhoehung = gehalt * 0.025;

            if (erhoehung < 150) // falls Erhöhung < 150 €
            {
                erhoehung = 150; // Erhöhung auf 150 € setzen
            }

            Console.WriteLine("Neues Gehalt: {0}", gehalt+erhoehung);
        }
    }
}
