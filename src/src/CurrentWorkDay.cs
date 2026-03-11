using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class CurrentWorkDay
    {
        private TimeOnly _startTime;
        private TimeOnly _endTime;
        private TimeSpan _workDuration;

        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public TimeSpan WorkDuration { get; set; }

        public CurrentWorkDay()
        {
            _startTime = StartTime;
            _endTime = EndTime;
        }

        public TimeSpan CalculateWorkDuration(TimeOnly startTime, TimeOnly endTime)
        {
            WorkDuration = endTime - startTime;
            return WorkDuration;
        }
    }
}
