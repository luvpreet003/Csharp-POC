namespace classes
{
    public class StopWatch
    {
        private DateTime _startTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
            {
                Console.WriteLine("Stopwatch already running!");
                return;
            }
            _startTime = DateTime.Now;
            _isRunning = true;
            Console.WriteLine("Stopwatch started!");
        }

        public TimeSpan Stop()
        {
            if (!_isRunning)
            {
                Console.WriteLine("Stop watch not started yet!");
                return TimeSpan.Zero;
            }
            _isRunning = false;
            var duration = DateTime.Now - _startTime;
            Console.WriteLine("Stopwatch stopped!");
            return duration;
        }
    }
        
}