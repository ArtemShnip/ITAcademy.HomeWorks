using System;
using System.Collections.Generic;
using System.Text;

namespace Hw09
{
    class Passenger
    {
        public string Name { get; set; }
        public string Passport { get; set; }
        public int WeightLuggage { get; set; }
        public int Ticket { get; set; }
        public int Gate { get; set; }
        public string Seat { get; set; }
        public override string ToString()
        {
            return $"Name {Name}, Pasport {Passport}, WeightLuggage {WeightLuggage}, Ticket {Ticket}, Gate {Gate}, mesto {Seat}";
        }
    }
}
