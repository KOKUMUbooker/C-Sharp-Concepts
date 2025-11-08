using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration + Initialization
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1,"One"},
                {2,"Two"},
                {3,"Three"}
            };
            Console.WriteLine($"myDictionary at id 1 : {myDictionary[1]}");


            Employee[] employees =
            {
                new Employee("CEO","Johnny",60,200),
                new Employee("Manager","Jonah",40,80),
                new Employee("HR","Judith",28,30),
                new Employee("Lead Dev","Arteta",30,60),
                new Employee("Intern","Barnes",25,35),
            };
            // Declaration
            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();
            foreach (Employee employee in employees)
            {
                // Adding elements to the dictionary
                employeeDictionary.Add(employee.Role, employee);
            }

            Console.Clear();
            const string key = "CEO";
            // Checking precence of a key in a dictionary (i)
            if (employeeDictionary.ContainsKey(key))
            {
                Employee emp1 = employeeDictionary[key];
                Console.WriteLine($"Employee Name {emp1.Name}, Role : {emp1.Role}, Salary : {emp1.Salary:N}");
            }
            else
            {
                Console.WriteLine($"Employee with this key : {key} does not exist.");
            }

            const string key2 = "CTO";
            Employee result = null;
            // Checking precence of a key in a dictionary (ii)
            if (employeeDictionary.TryGetValue(key2, out result))
            {
                Console.WriteLine($"Employee Name {result.Name}, Role : {result.Role}, Salary : {result.Salary:N}");
            }
            else
            {
                Console.WriteLine($"Employee with this key : {key2} does not exist.");
            }

            Console.WriteLine("\nAll employees : ");
            // Iterating over a dictionary & displaying the values based on the index u
            // sing .ElementAt() from Linq namespace
            for (int i = 0; i < employeeDictionary.Count; i++)
            {
                // <Diictonary>.ElementAt(index) - To do this you need the Linq class
                KeyValuePair<string, Employee> keyValuePair = employeeDictionary.ElementAt(i);
                // Print key
                Console.WriteLine($"Key : {keyValuePair.Key}");
                // Store the value in an employee obj
                Employee employeeValue = keyValuePair.Value;
                // Print Employee details
                Console.WriteLine($"Employee Name {employeeValue.Name}, Role : {employeeValue.Role}, Salary : {employeeValue.Salary:N}");
            }


            // Updating entry
            const string key3 = "Intern";
            if (employeeDictionary.ContainsKey(key3))
            {
                employeeDictionary[key3] = new Employee("Intern", "Johanna", 22, 30);
                Console.WriteLine($"Key to update {key3} found & updated succesfully");
            }
            else
            {
                Console.WriteLine($"Employee with key {key3} could not be found");
            }

            // Remove entry
            const string key4 = "HR";
            if (employeeDictionary.Remove(key4))
            {
                employeeDictionary[key4] = new Employee("Intern", "Johanna", 22, 30);
                Console.WriteLine($"Key to remove {key4} found & updated succesfully");
            }
            else
            {
                Console.WriteLine($"Employee with key {key4} could not be found");
            }

        }
    }
}
