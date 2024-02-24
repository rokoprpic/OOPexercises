

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime StartTime { get; set; }
        private TimeSpan Result = TimeSpan.Zero;
        private bool IsRunning = false;
        public void Start()
        {
            if (!IsRunning)
            {
                this.StartTime = DateTime.Now;
                this.IsRunning = true;
                Console.WriteLine("StopWatch started");
            }
            else
            {
                Console.WriteLine("StopWatch is already running!");
            }
        }
        public void Stop()
        {
            if (IsRunning)
            {
                this.Result = DateTime.Now - StartTime;
                this.IsRunning = false;
                Console.WriteLine("StopWatch ended");
                Console.WriteLine($"Timespan is: {Math.Round(Result.TotalSeconds, 2)} seconds!\n");
            }
            else
            {
                Console.WriteLine("Need to start StopWatch!");
            }
        }
    }
}