/*
 * Øvelse 0 - C# programmering trådpool øvelser
*/

namespace Opgave1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Program prg = new Program();

            // Loop that repeats 2 times. There are created 2 threads in a ThreadPool for both methods
            for (int i = 0; i < 2; i++)
            {
                ThreadPool.QueueUserWorkItem(prg.Task1);
                ThreadPool.QueueUserWorkItem(prg.Task2);
            }

            Console.Read();
        }

        // Method that is accessed by the threads in the ThreadPool from main
        public void Task1(object obj) 
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 1 is being executed");
            }
        }

        // Method that is accessed by the threads in the ThreadPool from main

        public void Task2(object obj)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Task 2 is being executed");
            }
        }


    }
}