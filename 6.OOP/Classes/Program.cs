using System;
  
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Human john = new Human("John","Doesy","Blue",24);
            john.IntroduceSelf();

            Human frank = new Human("Frank","Castle","Red",16);
            frank.IntroduceSelf();

            Human joey = new Human("Joey", "Schmidt");
            joey.IntroduceSelf();
        }
    }
}
