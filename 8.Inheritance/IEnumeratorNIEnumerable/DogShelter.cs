using System.Collections;
using System.Collections.Generic;

namespace IEnumeratorNIEnumerable
{
    class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("CupCake",false),
                new Dog("Casper",false),
                new Dog("Toby",false),
                new Dog("Princess",false),
            };
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}