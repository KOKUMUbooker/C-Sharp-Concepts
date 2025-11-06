using System;

namespace ReadingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Approach 1 :
            string text = System.IO.File.ReadAllText(@"sample.txt");
            Console.WriteLine($"Sample.txt file contains (Method 1 - using ReadAllText()) : \n{text}");

            Console.WriteLine();
            // Approach 2 :
            string[] lines = System.IO.File.ReadAllLines(@"sample.txt");
            Console.WriteLine("Sample.txt file contains (Approach 2 - using ReadAllLines()) : ");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
