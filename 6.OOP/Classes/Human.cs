using System;

namespace Classes
{
    public class Human
    {
        private string firstName;
        private string lastName;

        private string eyeColor;

        private int age;

        public Human()
        {
            Console.WriteLine("Default constructor called");
        }

        public Human(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // Parametrized Constructor
        public Human(string firstName,string lName,string eyeColor,int age)
        {
            this.firstName = firstName;
            this.eyeColor = eyeColor;
            this.age = age;
            lastName = lName;
        }

          public void IntroduceSelf()
        {
            Console.WriteLine($"Hello my name is {firstName} {lastName}. I {age} years old. My eye color is {eyeColor}.");
        }
    }
}
