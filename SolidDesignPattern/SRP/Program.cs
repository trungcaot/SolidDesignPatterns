﻿using System;

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

            var scheduler = new Scheduler();
            scheduler.AddEntry(new ScheduleTask { TaskId = 1, Content = "Do something now.", ExecuteOn = DateTime.Now.AddDays(5) });
            scheduler.AddEntry(new ScheduleTask { TaskId = 2, Content = "Don't forget to...", ExecuteOn = DateTime.Now.AddDays(2) });

            Console.WriteLine(report.ToString());
            Console.WriteLine(scheduler.ToString());

            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
            saver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);
        }
    }
}
