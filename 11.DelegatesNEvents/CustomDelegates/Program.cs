using System;
using System.Collections.Generic;

namespace CustomDelegates
{
    class Program
    {
        // defined filter delegate type for filtering Person instances
        public delegate bool FilterPeopleDelegate(Person p);
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("John",40),
                new Person("Elliot",15),
                new Person("Pennywise",1000),
                new Person("Antony",18)
            };

            Console.Clear();
            DisplayPeople("Minors", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);
        }

        static void DisplayPeople(string title, List<Person> people, FilterPeopleDelegate filter)
        {
            Console.WriteLine($"{title} : ");
            foreach (Person p in people)
            {
                // Check if this person passes the filter
                if (filter(p))
                {
                    Console.WriteLine($"{p.Name}, {p.Age} years old");
                }

            }
            Console.WriteLine();
        }

        // ================== FILTERS ===================
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }
        
        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}
