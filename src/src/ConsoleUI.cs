using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class ConsoleUI
    {
        CurrentWorkDay workDay = new CurrentWorkDay();

        public void StartUI()
        {
            Console.WriteLine("Möchten Sie die Arbeit beginnen? y/n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                SetStartTime();
            }
            Console.WriteLine("Möchten Sie die Arbeit beenden? y/n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
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
            workDay.EndTime = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine($"Deine Arbeitszeit endete um: {workDay.EndTime}.");
            CalWorkDuration();
        }

        public void CalWorkDuration()
        {
            workDay.CalculateWorkDuration(workDay.StartTime, workDay.EndTime);
            Console.WriteLine($"Arbeitszeit beträgt: {workDay.WorkDuration}");
        }
    }
}
