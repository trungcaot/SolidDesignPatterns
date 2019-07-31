using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;

        public SalaryCalculator(List<DeveloperReport> developerReports)
        {
            _developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;
            foreach (var devReport in _developerReports)
            {
                totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
            }
            return totalSalaries;
        }
    }
}
