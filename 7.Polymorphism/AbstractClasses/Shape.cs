using System;

namespace AbstractClasses
{
    // Instances can't be created from abstract
    // classes
    abstract class Shape
    {
        public string Name {get;set;}
        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {Name}");
        }

        public abstract double Volume();
    }
}