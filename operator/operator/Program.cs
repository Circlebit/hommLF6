using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @operator
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 111;
            float y = 9;

            Console.WriteLine("Summe = {0}", x + y);
            Console.WriteLine("Differenz = {0}", x - y);
            Console.WriteLine("Produkt = {0}", x * y);
            Console.WriteLine("Quotient = {0}", x / y);
            Console.WriteLine("Modquotient = {0}", x % y);

            // Unäre Operatoren testen
            int i = 10;
            Console.WriteLine("\n++i");
            Console.WriteLine("i = {0}", ++i);
            Console.WriteLine("i = {0}", ++i);
            Console.WriteLine("i = {0}", ++i);

            i = 10;
            Console.WriteLine("\ni++");
            Console.WriteLine("i = {0}", i++);
            Console.WriteLine("i = {0}", i++);
            Console.WriteLine("i = {0}", i++);

            i = 10;
            Console.WriteLine("\n--i");
            Console.WriteLine("i = {0}", --i);
            Console.WriteLine("i = {0}", --i);
            Console.WriteLine("i = {0}", --i);

            i = 10;
            Console.WriteLine("\ni--");
            Console.WriteLine("i = {0}", i--);
            Console.WriteLine("i = {0}", i--);
            Console.WriteLine("i = {0}", i--);

            i = 10;
            Console.WriteLine("\n-i");
            Console.WriteLine("i = {0}", -i);
            Console.WriteLine("i = {0}", -i);
            Console.WriteLine("i = {0}", -i);
        }
    }
}
