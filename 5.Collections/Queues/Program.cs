using System;
using System.Collections.Generic;

// Queues use FIFO
namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            // ======================= Example 1 ============================
            // Declare a queue
            Queue<int> queue = new Queue<int>();

            Console.Clear();

            // Add items to the queue (Add item to the end)
            queue.Enqueue(1);
            // Printing element at the front of the queue
            Console.WriteLine($"The value at the front of the queue is {queue.Peek()}");
            queue.Enqueue(2);
            Console.WriteLine($"The value at the front of the queue is {queue.Peek()}");
            queue.Enqueue(3);
            Console.WriteLine($"The value at the front of the queue is {queue.Peek()}");

            // Remove item (from the start)
            if (queue.Count > 0)
            {
                int removedItem = queue.Dequeue();
                Console.WriteLine($"\nThe value at the front of the queue after removing {removedItem} is {queue.Peek()}\n");
            }

            // Remove all items 
            while (queue.Count > 0)
            {
                int removedItem = queue.Dequeue();
                Console.WriteLine($"Deleted {removedItem} ...");
            }
            Console.WriteLine("Final count : {0}\n", queue.Count);


            // ======================= Example 2 ============================
            Queue<Order> orderQueue = new Queue<Order>();

            foreach (Order order in RecieveOrdersFromBranch1())
            {
                // Add each order to the queue
                orderQueue.Enqueue(order);
            }

            foreach (Order order in RecieveOrdersFromBranch2())
            {
                // Add each order to the queue
                orderQueue.Enqueue(order);
            }

            while (orderQueue.Count > 0)
            {
                // Remove the order at the front for every iteration &
                // store the order that got removed in a variable
                Order removedOrder = orderQueue.Dequeue();
                // Process the removed order
                removedOrder.ProcessOrder();
            }
        }

        static Order[] RecieveOrdersFromBranch1()
        {
            // Create new orders array
            Order[] orders = new Order[]
                {
                    new Order(1,5),
                    new Order(2,4),
                    new Order(3,20)
                };

            return orders;
        }
        static Order[] RecieveOrdersFromBranch2()
        {
            // Create new orders array
            Order[] orders = new Order[]
                {
                    new Order(4,5),
                    new Order(5,4),
                    new Order(6,20)
                };

            return orders;
        }
    }
}
