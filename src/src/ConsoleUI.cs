using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class ConsoleUI
    {
        public void StartUI(CurrentWorkDay workDay)
        {
            Console.WriteLine("Möchten Sie die Arbeit beginnen? y/n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                SetStartTime(workDay);
            }
            Console.WriteLine("Möchten Sie die Arbeit beenden? y/n");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                SetEndTime(workDay);
            }
        }

        public void SetStartTime(CurrentWorkDay workDay)
        {
            workDay.StartTime = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine($"Deine Arbeitszeit hat um: {workDay.StartTime} begonnen.");

        }

        public void SetEndTime(CurrentWorkDay workDay)
        {
            workDay.EndTime = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine($"Deine Arbeitszeit endete um: {workDay.EndTime}.");
            CalWorkDuration(workDay);
        }

        public void CalWorkDuration(CurrentWorkDay workDay)
        {
            workDay.CalculateWorkDuration(workDay.StartTime, workDay.EndTime);
            Console.WriteLine($"Arbeitszeit beträgt: {workDay.WorkDuration}");
        }
    }
}
