using System;
using System.Collections.Generic;

namespace DelegatesBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() {
                "John",
                "Jane",
                "Alice",
                "Pandemonium"
            };

            Console.Clear(); 
            Console.Write("Before : ");
            foreach (string name in names)
            {
                Console.Write($"{name}, ");
            }
            Console.WriteLine();
            
            names.RemoveAll(RemoveFilteredNames);

            Console.Write("After : ");
            foreach (string name in names)
            {
                Console.Write($"{name}, ");
            }
            Console.WriteLine();
        }
        static bool RemoveFilteredNames(string s){
            return s.Contains("P");
        }
    }
}
