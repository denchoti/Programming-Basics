using System;

namespace _16.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    double spendings = budget / 100.0 * 30;
                    Console.WriteLine($"Camp - {spendings:F2}");
                }
                else if (season == "winter")
                {
                    double spendings = budget / 100.0 * 70;
                    Console.WriteLine($"Hotel - {spendings:F2}");
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    double spendings = budget / 100.0 * 40;
                    Console.WriteLine($"Camp - {spendings:f2}");
                }
                else if (season == "winter")
                {
                    double spendings = budget / 100.0 * 80;
                    Console.WriteLine($"Hotel - {spendings:F2}");
                }

            }
            else
            {
                Console.WriteLine("Somewhere in Europe");

                double spendings = budget / 100.0 * 90;
                Console.WriteLine($"Hotel - {spendings:F2}");
            }
        }
    }
}
