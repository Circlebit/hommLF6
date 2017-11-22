using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double euro;
            double dollarkurs = 1.1599;

            do
            {
                Console.Write("Euro: ");
                euro = Convert.ToDouble(Console.ReadLine());
            } while (euro <= 0);


            Console.WriteLine(euro*dollarkurs + " $");
        }
    }
}
