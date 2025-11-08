using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Defining a new stack
            Stack<int> stack = new Stack<int>();

            Console.Clear();
            // Insert object a the top
            stack.Push(1);
            Console.WriteLine($"The top value in the stack is {stack.Peek()}");
            stack.Push(2);
            Console.WriteLine($"The top value in the stack is {stack.Peek()}");
            stack.Push(3);
            Console.WriteLine($"The top value in the stack is {stack.Peek()}");

            // Remove item - Pop() returns removed item
            // NOTE: You can't pop from an empty stack -> causes an error
            if (stack.Count > 0)
            {
                int removeditem = stack.Pop();
                Console.WriteLine($"\nRemoved item is {removeditem}");
                Console.WriteLine($"The top value in the stack is {stack.Peek()}\n");
            }

            // Iterate oe stack & delete all items
            while (stack.Count > 0)
            {
                int removeditem = stack.Pop();
                Console.WriteLine($"Deleted {removeditem}...");
            }
            Console.WriteLine($"Final stack count : {stack.Count}\n");


            // ==================== Reversing an array
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Defining new stack
            Stack<int> numStack = new Stack<int>();

            Console.Write("Reversing the array : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
                numStack.Push(numbers[i]);
            }
            Console.WriteLine();

            Console.Write("Result : ");
            while (numStack.Count > 0)
            {
                Console.Write($"{numStack.Pop()}, ");
            }
            Console.WriteLine();
        }
    }
}
