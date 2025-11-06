using System;
using System.Collections.Generic;

namespace PolymorphicParams
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Polymorphism at work #1
             - Areas where a base class instance is required as 
               an argument, a child class instance can also be used
               since it will be implicitly converted to the
               base class eg BMW & Audi instances being used
               were Car instances are required
            */
            var cars = new List<Car>()
            {
                new Audi(200,"Blue","A01"),
                new BMW(210,"Red","M1")
            };

            /*
            =================== Method Overidding =================
            - Entails marking a method in the base class as overridable
              using the virtual keyword & the derived class overriding 
              the aforementioned method using the override keyword.
            - This makes it such that even if a derived class gets casted
              or converted to a base class type, the overidden method 
              is what will get prioritized.

            Polymorphism at work #2
            - The Repair method is defined as a virtual method
              by the base class - Car, which the child elements
              override.
            - When it gets called the overrided methods of BMW & 
              Audi are what get called & not the method of the base class
              despite the BMW & Audi being treated as the Car type.
            */
            Console.Clear();
            foreach (Car car in cars)
            {
                car.Repair();
            }

            Console.WriteLine();
            Car BMWM3 = new BMW(300, "Blue", "M3");
            Car AudiR1 = new Audi(299, "Silver", "R1");

            // ================ Method hiding ====================
            /*
             - If the base class has defined some method & the derived
               classes also have defined their own implementation of the
               same method, method hiding occurs.
             - It can be explicit or implicit
             - Explicit method hiding occurs when the derived class marks
               the method to be hidden using the new keyword.
             - Implicit method hiding occurs when new keyword is not used.

             - Method hiding is NOT true polymorphism — 
               the derived method is only called when using a derived-type 
               reference. If the object is referenced through the base type, 
               the base method will be called instead.
             - In both explicit and implicit method hiding, the derived method 
               does not override the base version — it simply replaces it for
               derived-type references only. The base version is still used
               when called through a base-type reference.
            */

            // ShowDetails() method called is the one defined 
            // in the base class - Car, due to the implicit casting
            // of BMW & Audi to Car
            BMWM3.ShowDetails();
            AudiR1.ShowDetails();

            // ShowDetails() called is the one defined the 
            // the BMW - the derived class
            Console.WriteLine();
            BMW BMWM5 = new BMW(300, "Blue", "M5");
            BMWM5.ShowDetails();

            // ShowDetails() called is the one defined the 
            // the Car - the Base class
            Console.WriteLine();
            // Gets implicitly converted to Car - Similar to : 
            // Car carB = (Car)BMWM5;
            Car carB = BMWM5;
            carB.ShowDetails();
            
            Console.WriteLine();
            M3 myM3 = new M3(300, "Yellow", "M3");
            myM3.Repair();
        
        
        
        
        
        }
    }
}
