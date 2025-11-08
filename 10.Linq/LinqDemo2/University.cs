using System;

namespace LinqDemo2
{
    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public University(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void Print(){
            Console.WriteLine($"University {Name} with id {Id}");
        }
    }
}