using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            var task = Task.Run(()=>
            {
                Console.WriteLine($"Task started: thrId{Thread.CurrentThread.ManagedThreadId}"); // starts in another thread
                for (int i = 0; i < 280; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(200);
                }
            });


            Console.WriteLine($"Main thrId{Thread.CurrentThread.ManagedThreadId}");
            Print("!");
            task.Wait();
            Console.ReadKey();
        }

        static void Print(string s)
        {
            for (int i = 0; i < 80; i++)
            {
                Console.Write(s);
                Thread.Sleep(100);
            }
        }
    }
}
