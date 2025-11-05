namespace InheritanceDemo
{
    // Base classs
    class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public void SwitchOn()
        {
            this.IsOn = true;
        }

        public void SwitchOff()
        {
            this.IsOn = false;
        }

        public ElectricalDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }
    }
}