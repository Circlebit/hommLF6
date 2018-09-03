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
        public double InterestRate { get; set; }
        //public double InterestRate { get => InterestRateInPercent / 100; }
        public double MonthlyRate { get => CalcMonthlyRate(SumLent, RepaymentRate, InterestRate); }

        public DataTable TimeCourse { get; private set; }
        #endregion

        public Mortgage(double sumLent, double repaymentRate, double interestRate)
        {
            SumLent = sumLent;
            RepaymentRate = repaymentRate;
            InterestRate = interestRate;
            TimeCourse = CalcTimeCourse(SumLent, RepaymentRate, InterestRate);
        }


        private DataTable CalcTimeCourse(double sumLent, double repaymentRate, double interestRate)
        {
            int month = 1;
            double remainingDebtAtBeginning = sumLent;
            double interestAmount;
            double repaymentAmount;
            double remainingDebtAtEnd;
            var timeCourse = newTimeCourseTable();

            do
            {
                interestAmount = CalcInterestAmount(remainingDebtAtBeginning, interestRate);
                repaymentAmount = CalcRepaymentAmount(MonthlyRate, interestAmount);
                remainingDebtAtEnd = CalcRemainingDebtForNextMonth(remainingDebtAtBeginning, repaymentAmount);

                var newRow = timeCourse.NewRow();
                newRow["Month"] = month;
                newRow["RemainingDebtAtBeginning"] = remainingDebtAtBeginning;
                newRow["RepaymentAmount"] = repaymentAmount;
                newRow["InterestAmount"] = interestAmount;
                newRow["RemainingDebtAtEnd"] = remainingDebtAtEnd;
                timeCourse.Rows.Add(newRow);

                month++;
                remainingDebtAtBeginning = remainingDebtAtEnd;
            } while ( remainingDebtAtEnd > 0 );

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
        public static double CalcMonthlyRate(double sumLent, double repaymentRate, double interestRate)
        {
            return (sumLent * (repaymentRate + interestRate)) / (100 * 12);
        }

        public static double CalcInterestAmount(double remainingDebt, double interestRate)
        {
            return (remainingDebt * interestRate) / (100 * 12);
        }

        public static double CalcRepaymentAmount(double monthlyRate, double interestAmount)
        {
            return monthlyRate - interestAmount;
        }

        public static double CalcRemainingDebtForNextMonth(double remainingDebtPrevious, double repaymentAmount)
        {
            return remainingDebtPrevious - repaymentAmount;
        }
        #endregion
    }

}
