using System;

namespace InheritanceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Default constructor ie Post(){} will be called if no args are provided
            // Post post1 = new Post();
            Console.Clear();

            Post post1 = new Post("Thanks for the birthday wishes", true, "Jon Doe");
            Console.WriteLine($"{post1.ToString()} \n");

            ImagePost imagePost0 = new ImagePost(); // Call only the the default constructor
            Console.WriteLine(imagePost0);
            Console.WriteLine();

            ImagePost imagePost1 = new ImagePost("Checkout my new shoes", "Jane Doe", "http://example.com", true);
            Console.WriteLine(imagePost1.ToString());
        }
    }
}
