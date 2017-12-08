using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe = 0;

            for (int i = 0; i <= 100; i++)
            {
                summe += i;
            }

            Console.WriteLine(summe);
        }
    }
}
