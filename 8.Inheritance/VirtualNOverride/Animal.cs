using System;

namespace VirtualNOverride
{
    // name,age,isHungry,
    // makeSound(), eat(), play()
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age, bool isHungry)
        {
            this.Name = name;
            this.Age = age;
            this.IsHungry = isHungry;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound...");
        }

        // Virtual keyword marks the method as overridable by the inheriting class
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating : Munch... Munch... Munch...");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry.");
            }
        }
        
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing : WouPow... Swooosh... Fwaaa...");
        }
    }
}