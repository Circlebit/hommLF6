using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();

            Console.Write("Dez: ");
            int i = Convert.ToInt32(Console.ReadLine());

            // i immer wieder durch 2 teilen. den rest jeweils an result anhängen.
            do
            {
                int bit = i % 2;
                i /= 2;
                result.Add(bit);
            } while (i > 0);

            result.Reverse(); // result umkehren

            // Ausgabe
            Console.Write("Bin: ");
            foreach(int digit in result)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
        }
    }
}
