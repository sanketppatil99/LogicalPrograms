using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public static class SimulateStopwatch
    {
        public static void simulateStopwatch()
        {
            
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Stopwatch is Started");
            stopwatch.Start();

            Console.WriteLine("To stop stopwatch Enter 1 = ");
            int a = Convert.ToInt32(Console.ReadLine());

            
            if (a == 1)
            {
                stopwatch.Stop();
            }
            Console.WriteLine("Time Elapsed : {0}",stopwatch.Elapsed);
            Console.ReadLine();

        }
    }
}