using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a> ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b> ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Euclid(a,b));
        }

        public static int Euclid(int a, int b)
        {
            if (a == 0)
                return b;
            else
            {
                while (b != 0)
                {
                    if (a > b)
                        a = a - b;
                    else
                        b = b - a;
                }
            }
            return a;
        }
    }
}
