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
            double anfangskapital = Convert.ToDouble(Console.ReadLine());
            double zinssatz = Convert.ToDouble(Console.ReadLine());

            double kapital = anfangskapital;
            int jahr = 1;

            while(kapital < anfangskapital)
            {
                kapital += kapital * zinssatz;
                Console.WriteLine($"Jahr: {jahr} \t Kapital: {kapital}");
            }
        }
    }
}
