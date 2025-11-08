using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // To remove warnings to upgrade
            Console.Clear();

            // Declare array & later assign individual array indices
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 40;
            grades[2] = 30;
            grades[3] = 20;
            grades[4] = 50;

            Console.Write("Grades array : ");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"{grades[i]}, ");
            }
            Console.WriteLine();

            // Declare & initialize arrays at the same time
            int[] student2Grades = { 23, 43, 5, 56, 76 };
            int[] student3Grades = new int[] { 50, 12, 5, 18, 90 };

            Console.Write("Student 3 grades : ");
            foreach (int grade in student3Grades)
            {
                Console.Write($"{grade}, ");
            }
            Console.WriteLine();

            Console.WriteLine($"len of student2Grades : {student2Grades.Length} , len of student3Grades : {student3Grades.Length}");
        }
    }
}
