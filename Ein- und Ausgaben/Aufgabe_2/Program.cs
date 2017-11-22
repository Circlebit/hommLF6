using System;

namespace Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatur in °F: ");
            string s = Console.ReadLine();
            double f = Convert.ToDouble(s);
            
            // °C = (°F − 32) / 1,8
            double c = (f - 32) / 1.8f;
            Console.WriteLine("{0} °F = {1} °C", f, c);
        }
    }
}
