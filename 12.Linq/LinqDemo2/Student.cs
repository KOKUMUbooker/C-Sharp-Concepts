using System;

namespace LinqDemo2
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign key
        public int UniversityId { get; set; }

        public Student(int id,string name,string gender,int age,int uniId)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.UniversityId = uniId;
        }

        public void Print()
        {
            Console.WriteLine($"Student {Name} with id {Id} of Gender {Gender} & age of {Age}");
        }
    }
}