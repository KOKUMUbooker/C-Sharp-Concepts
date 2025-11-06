using System;

namespace PolymorphicParams
{
    // Made the class sealed to prevent another class
    // from inheriting from this class
    sealed class M3:BMW
    {
        public M3(int hp, string color, string model) : base(hp, color, model)
        {
        }

        // BMW marked its Repair method as sealed thus,
        // we can't override it, we can only hide it
        public new void Repair()
        {
            Console.WriteLine("M3 got repaired...");
        }
    }
}