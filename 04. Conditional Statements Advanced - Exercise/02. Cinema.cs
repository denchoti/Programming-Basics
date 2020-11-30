using System;

namespace _12.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int collumns = int.Parse(Console.ReadLine());

            double ticket = 0;
            

            switch (projection)
            {
                case "Premiere":
                    ticket = 12.00;
                    break;
                case "Normal":
                    ticket = 7.50;
                    break;
                case "Discount":
                    ticket = 5.00;
                    break;
            }

            double total = rows * collumns * ticket;
            Console.WriteLine($"{total:F2} leva");
        }
    }
}
