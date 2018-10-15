using System;
using System.Windows.Forms;

namespace HypothekendarlehenLaufzeit
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
            double interestRate = double.Parse(textBox_InterestRate.Text);
            double repaymentRate = double.Parse(textBox_RepaymentRate.Text);
            Mortgage = new Mortgage(sumLent, interestRate, repaymentRate);

            var bindingSource1 = new BindingSource { DataSource = Mortgage.TimeCourse };
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns["Month"].HeaderText = "Monat";
            dataGridView1.Columns["Month"].DefaultCellStyle.Format = "#";
            dataGridView1.Columns["RemainingDebtAtBeginning"].HeaderText = "Restschuld";
            dataGridView1.Columns["RepaymentAmount"].HeaderText = "Tilgung";
            dataGridView1.Columns["InterestAmount"].HeaderText = "Zinsen";
            dataGridView1.Columns["InterestAmountCum"].HeaderText = "Zinsen kumuliert";
            dataGridView1.Columns["RemainingDebtAtEnd"].HeaderText = "Retschuld neu";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
