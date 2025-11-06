using System;

namespace PolymorphicParams
{
    class Audi:Car
    {
        public string Model { get; set; }
        private string Brand = "Audi";
        public Audi(int hp, string color, string model) : base(hp, color)
        {
             this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"{this.Brand} {this.Model} has HP of {this.HP} & is {this.Color} in color.");
        }

        public override void Repair()
        {
            Console.WriteLine($"{this.Brand} {this.Model} has been repaired!");
        }
    }   
}