using System;

namespace CustomInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCar = new Car(120f, "Red", "Bang!!!");
            myCar.Destroy();
        }
    }
}
