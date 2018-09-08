using System.Data;

namespace Hypothekendarlehen
{
    class Mortgage
    {
        #region Properties
        public double SumLent { get; set; }
        public double RepaymentRate { get; set; }
        public double InterestRate { get; set; }
        public double MonthlyRate => CalcMonthlyRate(SumLent, RepaymentRate, InterestRate);

        public DataTable TimeCourse { get; }
        #endregion

        public Mortgage(double sumLent, double interestRate, double repaymentRate)
        {
            SumLent = sumLent;
            InterestRate = interestRate;
            RepaymentRate = repaymentRate;
            TimeCourse = CalcTimeCourse(SumLent, InterestRate);
        }


        private DataTable CalcTimeCourse(double sumLent, double interestRate)
        {
            int month = 1;
            double remainingDebtAtBeginning = sumLent;
            double remainingDebtAtEnd;
            double interestAmount;
            double interestAmountCum = 0;
            double repaymentAmount;
            var timeCourse = newTimeCourseTable();

            do
            {
                interestAmount = CalcInterestAmount(remainingDebtAtBeginning, interestRate);
                interestAmountCum += interestAmount;

                repaymentAmount = CalcRepaymentAmount(MonthlyRate, interestAmount);
                if (repaymentAmount > remainingDebtAtBeginning)
                    repaymentAmount = remainingDebtAtBeginning;

                remainingDebtAtEnd = CalcRemainingDebtForNextMonth(remainingDebtAtBeginning, repaymentAmount);

                var newRow = timeCourse.NewRow();
                newRow["Month"] = month;
                newRow["RemainingDebtAtBeginning"] = remainingDebtAtBeginning;
                newRow["RepaymentAmount"] = repaymentAmount;
                newRow["InterestAmount"] = interestAmount;
                newRow["InterestAmountCum"] = interestAmountCum;
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
            newTable.Columns.Add("InterestAmountCum", typeof(double));
            newTable.Columns.Add("RemainingDebtAtEnd", typeof(double));
            return newTable;
        }


        #region Static Calculation Methods
        private static double CalcMonthlyRate(double sumLent, double repaymentRate, double interestRate)
        {
            return (sumLent * (repaymentRate + interestRate)) / (100 * 12);
        }

        private static double CalcInterestAmount(double remainingDebt, double interestRate)
        {
            return (remainingDebt * interestRate) / (100 * 12);
        }

        private static double CalcRepaymentAmount(double monthlyRate, double interestAmount)
        {
            return monthlyRate - interestAmount;
        }

        private static double CalcRemainingDebtForNextMonth(double remainingDebtPrevious, double repaymentAmount)
        {
            return remainingDebtPrevious - repaymentAmount;
        }
        #endregion
    }

}
