using System;

namespace PolymorphicParams
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // Establish a "Has A" relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void SetCardIDInfo(int idNum, string owner)
        {
            this.carIDInfo.IDNum = idNum;
            this.carIDInfo.Owner = owner;
        }
        
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car with ID {this.carIDInfo.IDNum} is owned by {this.carIDInfo.Owner}");
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