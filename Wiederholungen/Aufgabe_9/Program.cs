using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe = 0;
            int input = 0;

            while (true)
            {
                Console.Write(">");
                input = Convert.ToInt32(Console.ReadLine());
                if (input < 0) break;
                summe += input;
                Console.WriteLine(summe);
            } 
        }
    }
}
