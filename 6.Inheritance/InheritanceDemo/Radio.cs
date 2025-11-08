using System;

namespace InheritanceDemo
{
    // Radio specified to inherit from the ElectricalDevice class
    class Radio : ElectricalDevice
    {
        // use ":base(argsFromChildClassConstructor)" to pass arguments to the contructor of the base class
        public Radio(bool isOn, string brand):base(isOn,brand)
        {
            
        }
        
        public void ListenRadio()
        {
            if (this.IsOn)
            {
                Console.WriteLine("Listening to the radio!");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}