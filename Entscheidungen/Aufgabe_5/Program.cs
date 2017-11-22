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
            double einkommen;
            double steuern;

            Console.Write("Einkommen: ");
            einkommen = Convert.ToDouble(Console.ReadLine());

            if (einkommen >= 100000)
            {
                steuern = einkommen * 0.46;
            }
            else if (einkommen < 10000)
            {
                steuern = 0;
            }
            else
            {
                steuern = einkommen * 0.23;
            }

            Console.WriteLine("Steuern: {0}", steuern);
        }
    }
}
