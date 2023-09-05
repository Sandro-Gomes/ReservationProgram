using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationProgram.Entities
{
    internal class Seat
    {
        public Spectator Spectator { get; set; }
        public int Number { get; set; }
        public Seat(Spectator spectator, int number)
        {
            Spectator = spectator;
            Number = number;
        }

        public override string ToString()
        {
            return "Spectator: " + Spectator.Name + " / Seat Number: " + Number;
        }
    }
}
