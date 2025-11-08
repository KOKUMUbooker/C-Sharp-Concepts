using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStartNEnd
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Clear();

            // =========== Approach 1 ================
            Console.WriteLine("Approach 1 : ");
            Approach1();

            // =========== Approach 2 ================
            Console.WriteLine("\nApproach 2 : ");
            await Approach2();

            // =========== Approach 3 ================
            Console.WriteLine("\nApproach 3 : ");
            await Approach3();
        }

        static void Approach1()
        {
            // When it hits .Result, the main thread freezes until the Task completes.
            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(1000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} ended");
            });

            thread.Start();

            // This blocks the main thread
            var task = taskCompletionSource.Task.Result;

            Console.WriteLine("✅ This runs after the thread is done");
        }

        static async Task Approach2()
        {
            Console.WriteLine($"Main thread {Environment.CurrentManagedThreadId} waiting...");

            await Task.Run(async () =>
            {
                Console.WriteLine($"Worker thread {Environment.CurrentManagedThreadId} started");
                await Task.Delay(1000);
                Console.WriteLine($"Worker thread {Environment.CurrentManagedThreadId} ended");
            });

            Console.WriteLine("✅ Work completed — continuing execution...");
        }
        
        static async Task Approach3()
        {
            Console.WriteLine($"Main thread {Environment.CurrentManagedThreadId} waiting...");

            await Task.Run(async () =>
            {
                Console.WriteLine($"Worker thread {Environment.CurrentManagedThreadId} started");
                await Task.Delay(1000);
                Console.WriteLine($"Worker thread {Environment.CurrentManagedThreadId} ended");
            });

            Console.WriteLine("✅ Work completed — continuing execution...");
        }
    }
}
