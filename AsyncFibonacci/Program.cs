using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncFibonacci
{
    class Program
    {
        static long FibAlgoRec(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {

                return (FibAlgoRec(n - 1) + FibAlgoRec(n - 2));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Task.Run(() => FibAlgoRec(42)).ContinueWith((task) => Console.WriteLine($"Fib algo Result: {task.Result}"));

            while (true)
            {
                Console.Write("-");
                Thread.Sleep(500);
            }
        }
    }
}
