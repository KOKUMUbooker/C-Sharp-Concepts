using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1,"John",98);
            Student stud2 = new Student(2,"Mary",70);
            Student stud3 = new Student(3, "Lilian", 80);
            Student stud4 = new Student(4, "Danny", 85);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Console.Clear();
             
            // Casting is required since values of a hashtable are stored as an object
            Student storedStudent1 = (Student)studentsTable[stud1.Id];
            // Retrieve specific item from hashtable
            Console.WriteLine($"Stored stud1 : {storedStudent1.Name} , id : {storedStudent1.Id}, GPA : {storedStudent1.GPA}\n");

            // HashTables - are a collection of Dictionaries, 
            // Thus that can be iterated over
            // Retrieve all values from a hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student Entry : {temp.Name} , id : {temp.Id}, GPA : {temp.GPA}");
            }

            Console.WriteLine();
            // Alternative approach for looping over items 
            foreach (Student student in studentsTable.Values)
            {
                Console.WriteLine($"Student Value : {student.Name} , id : {student.Id}, GPA : {student.GPA}");
            }
        }
    }
}
