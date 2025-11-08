using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(9);
            Console.Clear();
            Console.WriteLine($"t1.Equals(t2): {t1.Equals(t2)}\nt1 == t2: {t1 == t2}");
        }
    }
}
