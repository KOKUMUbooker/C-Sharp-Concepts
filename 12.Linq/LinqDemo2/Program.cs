using System;

namespace LinqDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            Console.Clear();
            // ================ Example 1 =====================
            // um.MaleStudents();
            // um.FemaleStudents();
            // um.SortStudentsByAge();
            // um.AllStudentsFromMoi();

            // ================= Example 2 ====================
            // Console.WriteLine("List of supported universities : ");
            // for (int i = 0; i < um.universities.Count; i++)
            // {
            //     University uni = um.universities[i];
            //     Console.WriteLine($"{i + 1}) {uni.Name}, ID={uni.Id}");
            // }

            // Console.WriteLine("\nFrom the list above, enter the Id of the university whose students you wish to see : ");
            // string enteredId = Console.ReadLine();

            // int validId;
            // if (int.TryParse(enteredId, out validId))
            // {
            //     um.AllStudentsFromSpecificUni(validId);
            // }
            // else
            // {
            //     Console.WriteLine($"Failed to parse value {enteredId}");
            // }

            // ================ Example 3 =====================
            um.StudentsAndUniversitynameCollection();
        }
    }
}
