using System;

namespace IEnumeratorNIEnumerable
{
    class Program
    {
        // 1. IEnumarable<T> for generic collections [RECOMMENDED - is an improvement over IEnumarable]
        // 2. IEnumarable for non generic collections

        /*
        - The IEnumerator<T> contains a single method that you must
          implement when implementing this interface :

          GetEnumerator(), which returns an IEnumerator<T> object.
        
        - The returned IEnumerator<T> provides the ability to iterate
          through the collection by exposing a current propety at the
          object we are currently at in the collection.
        */

        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            Console.Clear();

            foreach(Dog dog in shelter)
            {
                if (!dog.IsNaughty)
                {
                    dog.GiveTreats(2);
                }
                else
                {
                    dog.GiveTreats(1);
                }
            }
        }
    }
}
