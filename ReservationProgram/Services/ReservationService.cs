using ReservationProgram.Entities;
using ReservationProgram.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ReservationProgram.Services
{
    internal class ReservationService
    {

        public bool ValidateSeat(Auditorium auditorium, int number)
        {
            if (number > auditorium.Seats.Length || number < 1)
            {
                throw new IndexOutOfRangeException("Invalid seat");
            }
            if (auditorium.Seats[number - 1] != null)
            {
                return false;
            }
            return true;
        }

        public void ChooseSeat(Auditorium auditorium,Spectator spectator, int number)
        {
            if (ValidateSeat(auditorium, number) != true)
            {
                throw new DomainException("Seat already occupied");
            }
            //Seleciona o assento e atribui a um ouvinte
            auditorium.AddSeat(spectator, number);
        }
    }
}
