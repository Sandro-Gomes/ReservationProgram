using ReservationProgram.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationProgram.Entities
{
    internal class Auditorium
    {
        public Seat[] Seats { get; set; } = new Seat[100];

        public Auditorium()
        {
        }

        public void AddSeat(Spectator spectator, int number)
        {
            Seats[number - 1] = new Seat(spectator, number);
        }
    }
}
