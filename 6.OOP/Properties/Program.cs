using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Box box = new Box(20,40,50);
            // box.SetLength(20);
            // box.Width = 40;
            // // Private height field set using the Height propety that contains a setter & getter 
            // box.Height = 50; 

            box.DisplayInfo();

            Console.WriteLine($"Box length : ",box.GetLength());
            Console.WriteLine($"Box height : "+ box.Height);
            Console.WriteLine($"Box width : "+ box.Width);
            Console.WriteLine("Hello World!");
        }
    }
}
