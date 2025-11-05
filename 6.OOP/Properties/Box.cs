using System;

namespace Properties
{
    class Box
    {
        // Member variable
        private int length;
        private int height;
        private int volume;
        public int Width { get; set; }

        // Constructor
        public Box(int length, int width, int height)
        {
            this.length = length;
            this.Width = width;
            this.height = height;
        }

        // Setting properties on a member variable
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public int Volume
        {
            get
            {
                return this.length * this.Width * this.height;
            }
        }

        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public void DisplayInfo()
        {
            volume = length * Width * height;
            Console.WriteLine($"Length is {length}, width is {Width}, height is {height}, volume is {volume:N}");
        }
    }
}