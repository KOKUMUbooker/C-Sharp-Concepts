using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo2
{
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University(1, "UON"));
            universities.Add(new University(2, "KE University"));
            universities.Add(new University(3, "Moi"));
            universities.Add(new University(4, "JKUAT"));
            universities.Add(new University(5, "TUK"));

            students.Add(new Student(1, "John", "male", 25, universities[0].Id));
            students.Add(new Student(2, "Jane", "female", 26, universities[1].Id));
            students.Add(new Student(3, "Olivia", "female", 21, universities[2].Id));
            students.Add(new Student(4, "Mary", "female", 19, universities[2].Id));
            students.Add(new Student(5, "Ian", "male", 20, universities[4].Id));
            students.Add(new Student(6, "Carla", "female", 20, universities[3].Id));
            students.Add(new Student(7, "Frank", "male", 20, universities[2].Id));
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male students : ");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
            Console.WriteLine();
        }
        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female students : ");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
            Console.WriteLine();
        }

        public void SortStudentsByAge()
        {
            IEnumerable<Student> sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Students sorted by age : ");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
            Console.WriteLine();
        }

        public void AllStudentsFromMoi()
        {
            IEnumerable<Student> moiStudents = from student in students where student.UniversityId == universities[2].Id select student;
            Console.WriteLine("All students from Moi : ");
            foreach (Student student in moiStudents)
            {
                student.Print();
            }
            Console.WriteLine();
        }

        public void AllStudentsFromSpecificUni(int uniId)
        {
            IEnumerable<Student> moiStudents = from student in students where student.UniversityId == universities[2].Id select student;
            University targetuni = universities.Find(uni => uni.Id == uniId);

            if (uniId > 0 && targetuni != null)
            {
                Console.WriteLine($"All students from {targetuni.Name} : ");
                foreach (Student student in moiStudents)
                {
                    student.Print();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"No university with the Id {uniId} ");
            }
        }

        // Create collections based on other collections
        public void StudentsAndUniversitynameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, Univerityname = university.Name };

            Console.WriteLine("New collection: ");
            foreach (var student in newCollection)
            {
                Console.WriteLine($"Student {student.StudentName} from university {student.Univerityname}");
            }
        }
    }
}