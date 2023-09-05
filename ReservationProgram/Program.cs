using ReservationProgram.Entities;
using ReservationProgram.Entities.Exceptions;
using ReservationProgram.Services;
using ReservationProgram.View;

namespace ReservationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReservationService reservationService = new ReservationService();
            Auditorium auditorium = new Auditorium();
            bool isRunning = true;

            while (isRunning)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to Reservation Program");
                    Console.WriteLine();
                    Console.WriteLine("[1] Add reservation");
                    Console.WriteLine("[2] Show seats");
                    Console.WriteLine("[3] Exit");
                    Console.WriteLine();
                    Console.Write("Choose an option:");
                    int opt = int.Parse(Console.ReadLine());
                    if (opt == 1)
                    {
                        Console.Clear();
                        Console.Write("Spectator's name: ");
                        Spectator spec = new Spectator(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("Choose an empty seat: ");
                        Console.WriteLine();
                        AuditoriumView.ShowSeats(auditorium);

                        Console.WriteLine();
                        Console.Write("Seat number: ");
                        int number = int.Parse(Console.ReadLine());
                        try
                        {
                            reservationService.ChooseSeat(auditorium, spec, number);
                        }
                        catch(DomainException e)
                        {
                            Console.WriteLine("Invalid seat: " + e.Message);
                        }
                    }
                    if (opt == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("[Auditorium Seats]");
                        Console.WriteLine();
                        AuditoriumView.ShowSeats(auditorium);
                        Console.WriteLine();
                        Console.WriteLine("(Press enter to return)");
                        Console.ReadLine();
                    }
                    if (opt == 3)
                    {

                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }

            }




        }
    }
}