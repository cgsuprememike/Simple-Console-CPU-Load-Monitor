using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Simple_Performance_Monitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Simple CPU Monitor");
            Console.ForegroundColor = ConsoleColor.Green;
            PerformanceCounter perfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");

            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("CPU Load: {0}%", perfCounter.NextValue());
            }
        }
    }
}
