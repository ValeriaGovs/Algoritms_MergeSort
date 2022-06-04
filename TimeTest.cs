using System;
using System.Diagnostics;

namespace Algoritms_MergeSort
{
    class TimeTest
    {

        public static void Test(int n, func f, string type)
        {
            Random r = new Random();
            var unsort = new int[n];
            for (int i = 0; i < n; i++)
            {
                unsort[i] = r.Next(0, n);
            }


            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();


            f(unsort);


            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("RunTime {0} {1} = {2}", type, unsort.Length, elapsedTime);
        }


           public delegate void func(int[] mass);
        
    }
}
