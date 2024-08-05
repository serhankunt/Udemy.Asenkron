using System;
using System.Threading;

namespace ThreadDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(ShowThreadStatus);
            thread.Start();

            Thread thread2 = new Thread(ShowThreadNames);
            thread2.Name = "ShowThreadStatus";
            thread2.IsBackground = true;
            thread2.Start();

            Console.WriteLine("Main thread is over");
            Console.ReadLine();
        }

        static void ShowThreadStatus()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("ShowThreadStatus is working");
                Thread.Sleep(1000);
            }
        }

        static void ShowThreadNames()
        {
            Console.WriteLine("Thread in progress: {0}", Thread.CurrentThread.Name);

            Thread.Sleep(3000);

            Console.WriteLine("Completed thread: {0}", Thread.CurrentThread.Name);
        }
    }
}
