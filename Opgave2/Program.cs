/*
 * Øvelse 1 - C# programmering trådpool øvelser
*/
using System.Diagnostics;
using System.Threading;

namespace Opgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a new instance of stopwatch
            Stopwatch sw = new Stopwatch();


            // using stopwatch to take time of the elapsed time from the execution of ThreadPoolMethod and ThreadMethod
            Console.WriteLine("Thread Pool Execution");
            sw.Start();
            ProcessWithThreadPoolMethod();
            sw.Stop();
            Console.WriteLine($"Time consumed by ThreadPoolMethod is: {sw.ElapsedTicks}\n");

            sw.Reset();

            Console.WriteLine("Thread Execution");
            sw.Start();
            ProcessWithThreadMethod();
            sw.Stop();
            Console.WriteLine($"Time consumed by ThreadMethod is: {sw.ElapsedTicks}");

            Console.Read();
        }
        // 
        static void Process(object obj)
        {
            /*
             * 1 for-loop gives high execution time - ThreadPool is fast
             * 2 for-loops gives fast execution time for ThreadPoolMethod while ThreadMethod is much slower
             */
            for (int i = 0; i < 100000; i++)
            {
                for (int n = 0; n < 100000; n++)
                {
                }
            }
        }
        /// <summary>
        /// Method that uses ThreadPool to execute the Process method
        /// </summary>
        static void ProcessWithThreadPoolMethod()
        {

            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
        /// <summary>
        /// Method that uses Thread to execute the Process method
        /// </summary>
        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }
    }
}