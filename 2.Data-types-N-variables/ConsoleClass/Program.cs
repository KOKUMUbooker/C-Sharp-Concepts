using System;

namespace ConsoleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Changing console colors
            Console.ForegroundColor = ConsoleColor.Black ;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            Console.Write("Enter a string & press enter :");
            string readInput = Console.ReadLine();
            Console.WriteLine(String.Format("You have entered {0}", readInput));

            Console.Write("Enter another string & press enter : ");
            int asciiValue = Console.Read();
            Console.WriteLine(String.Format("ASCII value is {0}", asciiValue));

            Console.WriteLine("Enter some key : ");
            // typedKey is a struct containing - typedKey.KeyChar, typedKey.Key, typedKey.Modifiers etc
            var typedKey = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(String.Format("You entered the key : {0}", typedKey.Key));
        }
    }
}
