using System;

namespace MembersNDestructors
{
    class Member
    {
        // Memeber - private fields
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        // Member - public field
        public int age;

        // JobTitle property for defining setters & getters for the private jobTitle field
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // Member constructor
        public Member()
        {
            age = 30;
            memberName = "Lucy";
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // Member - Finalizer/Destructor - Only one Destructor per class.
        ~Member()
        {
            // Destructors are used for cleanup
            Console.WriteLine("Object has just gone out of scope & is now being destroyed");
        }


        // Public member method - can be called from other classes
        public void IntroduceSelf(bool isFriend)
        {
            if (isFriend)
            {
                sharePrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi, my name is {memberName} & my job title is {jobTitle} and I'm {age} years old.");
            }
        }

        private void sharePrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }
    }
}