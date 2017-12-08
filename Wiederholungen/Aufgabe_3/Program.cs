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
            int summe = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    summe += i;
                }
            }

            Console.WriteLine(summe);
        }
    }
}
