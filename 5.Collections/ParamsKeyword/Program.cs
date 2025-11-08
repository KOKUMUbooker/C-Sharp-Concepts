using System;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            PrintMsgs("I dont know","Hello world","English","Foobar");
            Console.WriteLine();
            PrintObjs(123,"Hello", 125.093m, true, 9467.234F);
            Console.WriteLine();

            Console.WriteLine("Min : "+ MinV2(1, -2, 3, -40, 90, 2));
        }

        static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }

        static void PrintMsgs(params string[] sentences)
        {
            foreach (string sentence in sentences)
            {
                Console.Write(sentence + ", ");
            }
        }
        
        static void PrintObjs(params object[] stuff)
        {
            foreach(object item in stuff)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
