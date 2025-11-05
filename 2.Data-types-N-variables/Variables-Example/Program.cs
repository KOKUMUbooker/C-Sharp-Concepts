using System;

namespace Variables_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integrals
            sbyte x = 1;
            short y = 2;
            int z = 3;
            long m = 43487234823494;

            // Floating points
            float f1 = 0.5f;
            double f2 = 0.6;
            decimal f3 = 0.7m;

            // Int & floating operations
            Console.WriteLine("Double addition : " + (f2 + (double)z) );
            Console.WriteLine("Double division : " + (f2 / (double)z) );
            Console.WriteLine("Double division without casting : " + (f2 / z) );
            Console.WriteLine("Int division with int casting on float : " + ((int)f2 / z) );

            // Boolean
            bool switchVal = true;

            // Unicode characters & strings
            char c = '@';
            string name = "John Doe";
        
            Console.WriteLine(c + " " + name.ToUpper() + ", Age : " + x);
        }
    }


}
