using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            double totalTicketsCount = 0;
            double kidTicketsCount = 0;
            double studentTicketsCount = 0;
            double standardTicketsCount = 0;


            while (movieName != "Finish")
            {
                int seatsAvailiable = int.Parse(Console.ReadLine());

                string ticket = Console.ReadLine();
                double ticketCounter = 0;
               

                while (ticket != "End")
                {
                    switch (ticket)
                    {
                        case "kid":
                            kidTicketsCount++;
                            break;
                        case "standard":
                            standardTicketsCount++;
                            break;
                        case "student":
                            studentTicketsCount++;
                            break;
                    }


                    ticketCounter++;
                    if (ticketCounter == seatsAvailiable)
                    {
                        break;
                    }


                    ticket = Console.ReadLine();
                }

                totalTicketsCount += ticketCounter;

                double seatsTaken = ticketCounter / seatsAvailiable * 100;
                Console.WriteLine($"{movieName} - {seatsTaken:f2}% full.");

                movieName = Console.ReadLine();
;            }

            double kidTicketsPercent = kidTicketsCount / totalTicketsCount * 100;
            double standardTicketsPercent = standardTicketsCount / totalTicketsCount * 100;
            double studentTicketsPercent = studentTicketsCount / totalTicketsCount * 100;

            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercent:f2}% kids tickets.");



        }
    }
}
