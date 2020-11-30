using System;

namespace _20.Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {

            string year = Console.ReadLine().ToLower();
            int holidays = int.Parse(Console.ReadLine());
            int daysHome = int.Parse(Console.ReadLine());

            double daysSofia = 48 - daysHome;
            double playSofia = (3.0 / 4) * daysSofia;
            double playHolidays = (2.0 / 3) * holidays;
            double playTotal = playSofia + playHolidays + daysHome;


            if (year == "leap")
            {
                var playSum = playTotal + playTotal * 0.15;
                Console.WriteLine(Math.Truncate(playSum));
            }

            else if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(playTotal));
            }



        }
    }
}
