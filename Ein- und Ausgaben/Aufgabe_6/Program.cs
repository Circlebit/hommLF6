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
            Console.Write("string1: ");
            string string1 = Console.ReadLine();

            Console.Write("string2: ");
            string string2 = Console.ReadLine();

            Console.Write("zahl: ");
            int zahl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mein Name lautet {0} {1} und ich bn {2} Jahre alt.", string1, string2, zahl);
        }
    }
}
