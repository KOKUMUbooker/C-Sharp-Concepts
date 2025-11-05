using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion - small number to a bigger number type
            int smallNum = 1234;
            long largeNum = smallNum;

            float smallFloat = 12.56F;
            double largeFloat = smallFloat;

            // Explicit conversion - from larger type to smaller type
            double myDouble = 145.23;
            int myInt = Convert.ToInt32(myDouble);   // Alternative: int myInt = (int)myDouble;

            string floatString = myInt.ToString();
            
            bool myBool = true;
            string boolString = myBool.ToString();

            Console.WriteLine(floatString + boolString);
        }
    }
}
