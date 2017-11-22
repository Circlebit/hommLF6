using System;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatur in °C: ");
            string s = Console.ReadLine();
            double c = Convert.ToDouble(s);
            // °F = °C × 1,8 + 32
            double f = c * 1.8f + 32;
            Console.WriteLine("{0} °C = {1} °F", c, f);
        }
    }
}
