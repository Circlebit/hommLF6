using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    class Aufgabe_1
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("> ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
