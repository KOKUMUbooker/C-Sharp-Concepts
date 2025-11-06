using System;

namespace PolymorphicParams
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public  void ShowDetails()
        {
            Console.WriteLine($"Car has HP of {this.HP} & is {this.Color} in color.");
        }
        
        public virtual void Repair()
        {
            Console.WriteLine("Car has been repaired!");
        }
    }
}