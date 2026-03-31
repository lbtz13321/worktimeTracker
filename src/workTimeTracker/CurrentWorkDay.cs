<<<<<<<< HEAD:src/WorktimeLibrary/CurrentWorkDay.cs
﻿namespace WorktimeLibrary
========
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workTimeTracker
>>>>>>>> origin/main:src/workTimeTracker/CurrentWorkDay.cs
{
    public class CurrentWorkDay
    {
        private TimeOnly _startTime;
        private TimeOnly _endTime;
        private TimeSpan _workDuration;
        private TimeSpan _currentTime;

        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public TimeSpan WorkDuration { get; private set; }
        public TimeSpan CurrentTime { get; set; }

        public CurrentWorkDay()
        {
            _startTime = StartTime;
            _endTime = EndTime;
            _workDuration = WorkDuration;
            _currentTime = CurrentTime;
        }
    }
}
