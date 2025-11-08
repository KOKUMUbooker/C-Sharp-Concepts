using System;

namespace MembersNDestructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Member member1 = new Member();
            member1.IntroduceSelf(false);
        }
    }
}
