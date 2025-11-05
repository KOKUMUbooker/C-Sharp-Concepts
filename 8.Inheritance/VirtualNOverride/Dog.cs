using System;

namespace VirtualNOverride
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }

        // Constructor that recieves arguments & also passes some of those args to the base class
        public Dog(string name, int age, bool isHungry) : base(name, age, isHungry)
        {
            IsHappy = true;
        }

        // Overriding the Eat virual method defined in the base class - Animal
        public override void Eat()
        {
            // Used for calling the Eat() defined in the base class
            base.Eat();
        }

        // Overriding te MakeSound Virtual method
        public override void MakeSound()
        {
            Console.WriteLine("Wooof... Wooof... Wooof...");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine("Dog is not Happy!!!");
            }
        }
    }
}