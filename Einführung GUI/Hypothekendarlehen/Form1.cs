using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypothekendarlehen
{
    public partial class Form1 : Form
    {
        private Mortgage Mortgage { get; set; }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_CalcMortgage_Click(object sender, EventArgs e)
        {
            double sumLent = double.Parse(textBox_SumLent.Text);
            double repaymentRate = double.Parse(textBox_RepaymentRate.Text);
            double interestRate = double.Parse(textBox_InterestRateInPercent.Text);
            Mortgage = new Mortgage(sumLent, repaymentRate, interestRate);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Mortgage.TimeCourse;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns["Month"].DefaultCellStyle.Format = "#";
        }
    }
}
