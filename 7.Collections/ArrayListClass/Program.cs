using System;
using System.Collections;

namespace ArrayListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arraylist with undefined initial capacity
            ArrayList myArrList = new ArrayList();
            myArrList.Add("Hello");

            // Array list with a defined initial capacit
            ArrayList myArrList2 = new ArrayList(100);

            myArrList2.Add(true);
            myArrList2.Add(123);
            myArrList2.Add(2.5m);
            myArrList2.Add(200);
            myArrList2.Add(20.25);
            myArrList2.Add(0.5f);
            myArrList2.Add(123);
            myArrList2.Add("Hello world");

            // Remove a specific value from the array list(You need to know the value to be removed)
            myArrList2.Remove(123); // Removes the first instance of that value

            // Delete element at specific index
            myArrList2.RemoveAt(0);

            Console.Clear();
            Console.WriteLine("Array list count : "+ myArrList2.Count);

            double sum = 0;

            foreach (object item in myArrList2)
            {
                if (item is int || item is float || item is decimal)
                {
                    sum += Convert.ToDouble(item);
                }
                else if (item is double)
                {
                    sum += (double)item;
                }
                else if (item is string)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine($"Sum : {sum}" );
        }
    }
}
