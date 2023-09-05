using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservationProgram.Entities;

namespace ReservationProgram.View
{
    internal static class AuditoriumView
    {
        static string[] line = new string[10];
        static string[] column = new string[10];
        

        public static void ShowSeats(Auditorium auditorium)
        {
            //show all seats
            int seat = 0;
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < column.Length; j++)
                {
                    seat++;
                    if (auditorium.Seats[seat - 1] == null)
                    {
                        Console.Write("[" + seat.ToString("000") + "] ");
                    }
                    else{
                        Console.Write("[ X ] ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
