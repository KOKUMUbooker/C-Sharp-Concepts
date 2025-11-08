using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // // 1) Execute Everything on the main thread
            // Console.WriteLine("Hello World! 1");
            // Thread.Sleep(1000);
            // Console.WriteLine("Hello World! 2");
            // Thread.Sleep(1000);
            // Console.WriteLine("Hello World! 3");
            // Thread.Sleep(1000);
            // Console.WriteLine("Hello World! 4");
            // Thread.Sleep(1000);
            // Console.WriteLine("Hello World! 5");

            // 2) Execute all in parallel 
            // In the example below, not all logs will be displayed
            // after 1000ms. There can occasionally be some 
            // slight deviation on how long each statement blocks
            // get executed 
            // new Thread(() =>
            // {
            //     Thread.Sleep(1000);
            //     Console.WriteLine("Thread 1");
            // }).Start();
            // new Thread(() =>
            // {
            //     Thread.Sleep(1000);
            //     Console.WriteLine("Thread 2");
            // }).Start();
            // new Thread(() =>
            // {
            //     Thread.Sleep(1000);
            //     Console.WriteLine("Thread 3");
            // }).Start();
            // new Thread(() =>
            // {
            //     Thread.Sleep(1000);
            //     Console.WriteLine("Thread 4");
            // }).Start();
            // new Thread(() =>
            // {
            //     Thread.Sleep(1000);
            //     Console.WriteLine("Thread 5");
            // }).Start();

            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(1000);
                taskCompletionSource.TrySetResult(true);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} ended");
            });

            thread.Start();

            // ⛔ Blocks here until TrySetResult(true) is called in the thread above
            var task = taskCompletionSource.Task.Result;

            Console.WriteLine("✅ Task completed, continuing execution...");

        }
    }
}
