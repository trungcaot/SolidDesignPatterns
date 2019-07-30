using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome to Single Responsibility Principle
            // Example 1.

            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });

            Console.WriteLine(report.ToString());

            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
        }
    }
}
