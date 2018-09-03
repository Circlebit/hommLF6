using System;
using System.Windows.Forms;

namespace Währungsumrechnung
{
    public partial class Form1 : Form
    {
        public double Eur { get; private set; }
        public double Usd { get; private set; }
        public double KursEurUsd { get; set; }

        public Form1()
        {
            KursEurUsd = 0.5;
            Eur = 1.0;
            Usd = EurToUsd(Eur);
            
            InitializeComponent();

            textBoxEUR.Text = Eur.ToString();
            textBoxUSD.Text = Usd.ToString();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {     
            Double.TryParse(textBoxEUR.Text, out double eur);
            Usd = EurToUsd(eur);
            textBoxUSD.Text = Convert.ToString(Usd);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double EurToUsd(double eur)
        {
            return eur*KursEurUsd;
        }
    }
}
