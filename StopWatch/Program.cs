

namespace StopWatch
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();
            while(true)
            {
                Console.WriteLine("START - start StopWatch | STOP - stop StopWatch| END - finish program)! \n");
                var input = Console.ReadLine()?.ToLower();
                switch (input)
                {
                    case "start":
                        stopwatch.Start();
                        break;
                    case "stop":
                        stopwatch.Stop();
                        break;
                    case "end":
                        Console.WriteLine("Program end");
                        return;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
        }
    }
}

