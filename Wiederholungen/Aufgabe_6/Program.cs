using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe = 0;
            int zahl = 1;

            Console.Write("Ganzzahl> ");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            while (zahl <= eingabe)
            {
                summe = summe + zahl;
                zahl++;
            }

            Console.WriteLine($"Alle Zahlen bis zu einschl. {eingabe} addiert: {summe}");
        }
    }
}
