using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"|-------|-------|");
            Console.WriteLine($"|   C°  |   F°  | ");
            Console.WriteLine($"|-------|-------|");
            for (int celsius = -25; celsius <= 50; celsius += 5)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"| {celsius} \t| {fahrenheit} \t| ");
            }
            Console.WriteLine($"|-------|-------|\n");


        }
    }
}
