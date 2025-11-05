using System;

namespace VirtualNOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Dog dog = new Dog("CupCake", 4, false);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }
}
