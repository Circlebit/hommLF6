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
            double a, b;

            Console.Write("a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("Division durch 0 nicht möglich");
            }
            else
            {
                Console.WriteLine("{0} : {1} = {2}", a, b, a/b);
            }
        }
    }
}
