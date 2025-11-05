using System;

namespace CustomInterfaces
{
    // C# does not support multiple class inheritance
    class Car : Vehicle, IDestroyable
    {
        public Car(float speed,string color,string destructionSound):base(speed,color)
        {
            this.DestructionSound = destructionSound;
        }

        public string DestructionSound { get; set; }

        public void Destroy()
        {
            Console.WriteLine($"Playing destruction sound : {DestructionSound}");
            Console.WriteLine("Create fire ....");
        }
    }
}