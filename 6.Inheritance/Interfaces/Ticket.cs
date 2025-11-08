using System;

namespace Interfaces
{
    /*
     IEquatable<T> - requires that classes implementing 
                     it must define a "bool Equals(T )" 
                     method  
    */
    class Ticket : IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }

        public Ticket(int durationInHours)
        {
            this.DurationInHours = durationInHours;
        }

        public bool Equals(Ticket otherTicket)
        {
            return this.DurationInHours == otherTicket.DurationInHours;
        }
    }
}