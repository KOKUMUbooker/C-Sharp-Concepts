using System;

namespace PolymorphicParams
{
    class BMW : Car
    {
        public string Model { get; set; }
        private string Brand = "BMW";
        public BMW(int hp, string color, string model) : base(hp, color)
        {
             this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"{this.Brand} {this.Model} has HP of {this.HP} & is {this.Color} in color.");
        }

        // Added sealed keyword to prevent overriding by 
        // a child class of BMW
        // The sealed keyword must come before the override
        // keyword
        // sealed keyword only works on methods that can be
        // overridden ie those marked by base class using 
        // virtual keyword
        public sealed override void Repair()
        {
            Console.WriteLine($"{this.Brand} {this.Model} has been repaired!");
        }
    }   
}