using System;

namespace IEnumeratorNIEnumerable
{
    class Dog
    {
        public string Name { get; set; }
        public bool IsNaughty { get; set; }
        public Dog(string name, bool isNaughty)
        {
            this.Name = name;
            this.IsNaughty = isNaughty;
        }    

        public void GiveTreats(int numberOfTreats)
        {
            Console.WriteLine($"Dog {this.Name} is getting {numberOfTreats} treats.");
        }
    }
}