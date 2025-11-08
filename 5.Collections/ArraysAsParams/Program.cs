using System;

namespace ArraysAsParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] studentGrades = { 50, 60, 50, 89, 90, 60, 40 };
            double avgResult = GetAverage(studentGrades);

            Console.WriteLine($"The average of the {studentGrades.Length} is {avgResult:N}");
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < gradesArray.Length; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;

            return average;
        }
    }
}
