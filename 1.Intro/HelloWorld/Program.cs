using System; // 1. Brings in all classes defined in the System namespace into our file eg the Console class

namespace HelloWorld // 2. Defines a namespace that will house clasess defined in this file
{
    class Program // 3. A class deifinition
    {
        // 4.Entry point of the program
        // "static" used so that to call the Main function a class instance doesn't have to be created
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Booker!");
        }
    }
}
