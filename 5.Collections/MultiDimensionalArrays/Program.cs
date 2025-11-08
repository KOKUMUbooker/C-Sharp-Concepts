using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // 2D array
            int[,] twoDArray = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,10},
                {10,11,12}
            };

            twoDArray[2, 2] = 9;
            Console.WriteLine($"twoDArray.Length : {twoDArray.Length}");
            Console.WriteLine($"twoDArray.GetLength(0) : {twoDArray.GetLength(0)}");
            Console.WriteLine($"twoDArray.GetLength(1) : {twoDArray.GetLength(1)}");
            
            for (int i = 0; i < twoDArray.GetLength(0); i++)
            {
                Console.Write($"Row {i} values : ");
                for (int j = 0; j < twoDArray.GetLength(1); j++)
                {
                    Console.Write($"{twoDArray[i,j]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
