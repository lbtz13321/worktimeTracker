using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workTimeTracker
{
    public class ConsoleUI
    {
        CurrentWorkDay workDay = new CurrentWorkDay();
        Stopwatch stopwatch = new Stopwatch();

        public void StartUI()
        {
            Console.WriteLine("Möchten Sie die Arbeit beginnen? y");
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
                    TimeSpan totalSecondsElapsed = TimeSpan.FromSeconds(Convert.ToInt32(stopwatch.Elapsed.TotalSeconds));
                    Console.Write(totalSecondsElapsed.ToString("c"));
                    Console.Write('\r');
                    Thread.Sleep(1000);
                }
            });
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Möchten Sie die Arbeit beenden? y");
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
            stopwatch.Stop();
            workDay.EndTime = TimeOnly.FromDateTime(DateTime.Now);
            workDay.CurrentTime = stopwatch.Elapsed;
            Console.WriteLine($"Deine Arbeitszeit endete um: {workDay.EndTime}.");
            Console.WriteLine($"Die Arbeitszeit betrug: {workDay.CurrentTime}");
        }
    }
}
