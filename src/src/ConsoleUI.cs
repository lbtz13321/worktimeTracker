using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class ConsoleUI
    {
        CurrentWorkDay workDay = new CurrentWorkDay();
        Stopwatch stopwatch = new Stopwatch();

        public void StartUI()
        {
            Console.WriteLine("Möchten Sie die Arbeit beginnen? y/n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                stopwatch.Start();
                SetStartTime();
                Console.Clear();
            }

            var stopwatchTask = Task.Run(() =>
            {
                while (true)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Arbeitszeit: {stopwatch.Elapsed}");
                    Thread.Sleep(100);
                }
            });
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Möchten Sie die Arbeit beenden? y/n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                SetEndTime();
            }
        }

        public void SetStartTime()
        {
            workDay.StartTime = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine($"Deine Arbeitszeit hat um: {workDay.StartTime} begonnen.");
        }

        public void SetEndTime()
        {
            Console.Clear();
            workDay.EndTime = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine($"Deine Arbeitszeit endete um: {workDay.EndTime}.");
            Console.WriteLine($"Die Arbeitszeit betrug: {stopwatch}");
            // CalWorkDuration(workDay);
        }

        //public void CalWorkDuration(CurrentWorkDay workDay)
        //{
        //    workDay.CalculateWorkDuration(workDay.StartTime, workDay.EndTime);
        //    Console.WriteLine($"Arbeitszeit beträgt: {workDay.WorkDuration}");
        //}
    }
}
