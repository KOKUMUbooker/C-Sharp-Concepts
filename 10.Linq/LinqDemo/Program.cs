using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            OddNumbers(numbers);
        }
        
        static void OddNumbers(int[] numbers)
        {
            Console.Write("Odd numbers : ");
            IEnumerable<int> oddNumers = from number in numbers where number % 2 != 0 select number;

            foreach (int num in oddNumers)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }
    }
}
