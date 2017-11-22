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
            string s;
            double radius;
            double Acircle;
            double Vsphere;
            double Asquare;
            double Acube;
            double Atriangle;

            Console.Write("Geben Sie eine Zahl ein: ");
            s = Console.ReadLine();
            radius = Convert.ToDouble(s);

            Console.WriteLine("\nKreisfläche:");
            Console.WriteLine("  r = {0}", radius);
            Acircle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("  A = Pi ⋅ r²");
            Console.WriteLine("  A = {0}", Acircle);

            Console.WriteLine("\nKugelvolumen:");
            Console.WriteLine("  r = {0}", radius);
            Vsphere = (3.0/4.0) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine("  V = (4/3) ⋅ Pi ⋅ r³");
            Console.WriteLine("  V = {0}", Vsphere);

            Console.WriteLine("\nFläche Quadrat:");
            Console.WriteLine("  a = {0}", radius);
            Asquare = Math.Pow(radius, 2);
            Console.WriteLine("  A = a²");
            Console.WriteLine("  A = {0}", Asquare);

            Console.WriteLine("\nFläche Quadrat:");
            Console.WriteLine("  a = {0}", radius);
            Acube = Math.Pow(radius, 3);
            Console.WriteLine("  A = a³");
            Console.WriteLine("  A = {0}", Acube);

            Console.WriteLine("\nFläche Dreieck");
            Console.WriteLine("  a = {0}", radius);
            Atriangle = ( (Math.Pow(radius, 2)/4)*Math.Sqrt(3) );
            Console.WriteLine("  A = (a²/4)*√3");
            Console.WriteLine("  A = {0}", Atriangle);
        }
    }
}
