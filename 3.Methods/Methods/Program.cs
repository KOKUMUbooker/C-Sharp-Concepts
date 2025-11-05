using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            printMsg();
        }

        static public void printMsg()
        {
            Console.WriteLine("Hello this is a message printed by the printMsg function");
        }
    }
}
