using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hypothekendarlehen
{
    class Mortgage
    {
        #region Properties
        public double SumLent { get; set; }
        public double RepaymentRate { get; set; }
        public double InterestRateInPercent { get; set; }
        public double InterestRate { get => InterestRateInPercent / 100; }

        public DataTable TimeCourse { get; private set; }
        #endregion

        public Mortgage(double sumLent, double repaymentRate, double interestRateInPercent)
        {
            SumLent = sumLent;
            RepaymentRate = repaymentRate;
            InterestRateInPercent = interestRateInPercent;
        }


        private DataTable CalcTimeCourse(double sumLent, double repaymentRate, double interestRate)
        {
            int month = 1;
            double remainingDebtAtBeginning = sumLent;
            double interestAmount = InterestAmount(remainingDebtAtBeginning, interestRate);

            var timeCourse = newTimeCourseTable();

            do
            {
                var newRow = timeCourse.NewRow();
                
            } while ( XXXXXXXXXXXXXX );

            return timeCourse;
        }

        private DataTable newTimeCourseTable()
        {
            var newTable = new DataTable("TimeCourse");
            newTable.Columns.Add("Month", typeof(int));
            newTable.Columns.Add("RemainingDebtAtBeginning", typeof(double));
            newTable.Columns.Add("RepaymentAmount", typeof(double));
            newTable.Columns.Add("InterestAmount", typeof(double));
            newTable.Columns.Add("RemainingDebtAtEnd", typeof(double));
            return newTable;
        }

        #region Calculation Methods
        public static double MonthlyRate(double sumLent, double repaymentRate, double interestRate)
        {
            return (sumLent * (repaymentRate + interestRate)) / (100 * 12);
        }

        public static double InterestAmount(double remainingDebt, double interestRate)
        {
            return (remainingDebt * interestRate) / (100 * 12);
        }

        public static double RepaymentAmount(double monthlyRate, double interestAmount)
        {
            return monthlyRate - interestAmount;
        }

        public static double RemainingDebtForNextMonth(double remainingDebtPrevious, double repaymentAmount)
        {
            return remainingDebtPrevious - repaymentAmount;
        }
        #endregion
    }

}
