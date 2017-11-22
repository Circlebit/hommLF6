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
            Console.Write("Geben Sie ein einzelnes Zeichen ein: ");
            char[] arr = Console.ReadLine().ToCharArray();
            char c = arr[0];
            Console.WriteLine("Zeichen: \t{0}", c);
            int i = (int)c;
            Console.WriteLine("Code: \t\t{0}", i);
            i += 32;
            Console.WriteLine("Code + 32: \t{0}", i);
            c = (char)i;
            Console.WriteLine("Zeichen + 32: \t{0}", c);
        }
    }
}
