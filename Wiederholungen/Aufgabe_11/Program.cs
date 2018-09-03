using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double darlehenssumme = 100000;
            double zinssatz = 4;
            double tilgungssatz = 1;
            double zinsen;
            double zinsenGesamt = 0;
            double tilgung;
            double restschuld = darlehenssumme;
            double monatsrate = Monatsrate(darlehenssumme, tilgungssatz, zinssatz);
            int laufzeit = 0;

            do
            {
                laufzeit++;
                zinsen = Zinsen(restschuld, zinssatz);
                zinsenGesamt += zinsen;
                tilgung = Tilgung(monatsrate, zinsen);
                restschuld = Restschuld(restschuld, tilgung);
            } while (restschuld > monatsrate);

            Console.WriteLine($"Laufzeit: {laufzeit} Monate\nZinsen gesamt: {zinsenGesamt.ToString("0.00")} Euro");
        }

        public static double Monatsrate(double darlehensumme, double tilgungssatz, double zinssatz)
        {
            return (darlehensumme*(tilgungssatz + zinssatz)) / (100 * 12);
        }

        public static double Zinsen(double restschuld, double zinssatz)
        {
            return (restschuld * zinssatz) / (100 * 12);
        }

        public static double Tilgung(double monatsrate, double zinsen)
        {
            return monatsrate - zinsen;
        }

        public static double Restschuld(double restschuldAlt, double tilgung)
        {
            return restschuldAlt - tilgung;
        }
    }
}
