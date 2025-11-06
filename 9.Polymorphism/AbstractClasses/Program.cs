using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Cube(5), new Cube(3) };
            
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}");

                // "as" keyword is used to try & convert some 
                // value into some type which if successfull
                // will contain the value otherwise will be null
                Cube isCube = shape as Cube;
                if (isCube == null)
                {
                    Console.WriteLine($"This shape is no cube.");
                }
                
                // "is" keyword only checks whether some value
                // is a particular type
                if(shape is Cube)
                {
                    Console.WriteLine("This is a cube.");
                }
            }
        }
    }
}
