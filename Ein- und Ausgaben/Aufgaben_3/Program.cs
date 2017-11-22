using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s; // Input
            double strecke; // Fahrtstrecke in km
            double verbrauch_gesamt; // Verbrauch für strecke in Liter
            double verbrauch_100km;  // Verbrauch für 100 km in Liter
            double preis_gesamt;
            double preis_liter;
            Console.WriteLine(" --------------------------\n  Fahrtkostenrechner 2000+\n --------------------------\n");
                               
            // Nutzereingaben
            Console.Write("Fahrtstrecke in km: ");
            s = Console.ReadLine();
            strecke = Convert.ToDouble(s);

            Console.Write("Treibstoffverbrauch für Strecke in Liter: ");
            s = Console.ReadLine();
            verbrauch_gesamt = Convert.ToDouble(s);

            Console.Write("Literpreis: ");
            s = Console.ReadLine();
            preis_liter = Convert.ToDouble(s);

            // Berechnungen
            verbrauch_100km = (verbrauch_gesamt / strecke) * 100;
            preis_gesamt = verbrauch_gesamt * preis_liter;

            // Ausgabe
            Console.WriteLine("Verbrauch auf 100 km: {0}", verbrauch_100km);
            Console.WriteLine("Treibstoffkosten für gesamte Strecke: {0}", preis_gesamt);
        }
    }
}
