using System;
using System.IO;

namespace WritingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // Approach 1 - WriteAllLines :
            string[] lines = { "First line", "Second line", "Third line" };

            File.WriteAllLines(@"allLines.txt", lines);

            // Approach 2 - WriteAllText
            Console.Write("Please provide a name for the file : ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter content for the file : ");
            string content = Console.ReadLine();

            File.WriteAllText($@"{fileName}.txt", content);

            // Approach 3 : StreamWriter
            /*
              "using" Defines a scope that ensures an object is automatically
              disposed (cleaned up) when done — a feature of the
              IDisposable interface.
              - This is syntactic sugar for code : 
                
                StreamWriter file = new StreamWriter(@"streamWriter.txt");
                try
                {
                    foreach (string line in lines)
                    {
                        file.WriteLine(line);
                    }
                }
                finally
                {
                    file.Dispose(); // Ensures file is closed, even if an exception occurs
                }
            */
            using (StreamWriter file = new StreamWriter(@"streamWriter.txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}
