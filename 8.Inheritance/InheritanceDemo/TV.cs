using System;

namespace InheritanceDemo
{
    class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
        }

        public void WatchTV()
        {
            if (this.IsOn)
            {
                Console.WriteLine("Watching to the TV!");
            }
            else
            {
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }

    }
}