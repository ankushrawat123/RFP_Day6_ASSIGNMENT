using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RFP_Day6_ASSIGNMENT
{
    internal class StopWatch
    {
        public void stopWatchMethod()
        {


            Console.WriteLine("Hit any key to start the timer");
            Console.ReadKey();
            Console.WriteLine();
            var watch = Stopwatch.StartNew();
          
            Console.Write("Press <Enter> to exit stopwatch... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                watch.Stop();
            }
            Console.WriteLine($"Execution Time : {watch.ElapsedMilliseconds} ms");
        }
    }
}
