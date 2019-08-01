using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerReports;

        public SalaryCalculator(List<BaseSalaryCalculator> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            // Item 1:
            //double totalSalaries = 0D;
            //foreach (var devReport in _developerReports)
            //{
            //    totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
            //}
            //return totalSalaries;


            // Item 2.
            // ----------------
            // Even though this solution is going to give us the correct result, this is not an
            // optimal solution.
            //-----------------
            double totalSalaries = 0D;
            foreach (var devReport in _developerReports)
            {
                totalSalaries += devReport.CalculateSalary();
            }
            return totalSalaries;
        }
    }
}
