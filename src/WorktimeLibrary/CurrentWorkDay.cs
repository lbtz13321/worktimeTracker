namespace WorktimeLibrary
{
    public class CurrentWorkDay
    {
        private TimeOnly _startTime;
        private TimeOnly _endTime;
        private TimeSpan _workDuration;

        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public TimeSpan WorkDuration { get; private set; }

        public CurrentWorkDay()
        {
            _startTime = StartTime;
            _endTime = EndTime;
            _workDuration = WorkDuration;
        }
    }
}
