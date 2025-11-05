namespace CustomInterfaces
{
    class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        // Default constructor
        public Vehicle()
        {
            Speed = 120F;
            Color = "white";
        }

        public Vehicle(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}