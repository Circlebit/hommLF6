using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debugging_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBerechnePrimzahlen_Click(object sender, EventArgs e)
        {
            uint maxvalue = Convert.ToUInt32(textBoxMaxWert.Text);
            berechnePrimzahlen(maxvalue);
        }

        private void berechnePrimzahlen(uint _mv)
        {
            // Lösche alle Einträge in der listBoxPrimzahlen
            listBoxPrimzahlen.Items.Clear();
            
            // Für alle Zahlen von 2 bis einschließlich _mv
            // ermitteln, ob sie Primzahlen sind
            for (uint i = 2; i <= _mv; i++)
            {
                bool prim = false;
                prim = istZahlEinePrimzahl(i);

                if (prim)
                    listBoxPrimzahlen.Items.Add(i.ToString());
            }
        }

        private bool istZahlEinePrimzahl(uint _z)
        {
            // Hier wird eine einzelne Zahl geprüft,
            // ob sie eine Primzahl ist.
            // Falls ja, ist prim = true; andernfalls false

            bool prim = true;

            // Geprüft wird bis zum Ganzzahlanteil von
            // Wurzel aus _z
            uint length = (uint)Math.Sqrt(_z);

            for (int i = 1; i < length; i++)
            {
                if ( _z % i == 0)
                {
                    // Falls kein Divisionrest --> nicht prim
                    prim = false;
                    // Schleife vorzeitig beenden
                    break;
                }
            }

            return prim;
        }
    }
}
