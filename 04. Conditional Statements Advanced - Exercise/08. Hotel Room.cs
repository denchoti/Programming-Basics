using System;

namespace _18.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = nights * 50;
                priceApartment = nights * 65;

                if (nights > 7 && nights <= 14)
                {
                    priceStudio = priceStudio - 0.05 * priceStudio;
                }
                else if (nights > 14)
                {
                    priceStudio = priceStudio - 0.30 * priceStudio;
                }
            }

            else if (month == "June" || month == "September")
            {
                priceStudio = nights * 75.20;
                priceApartment = nights * 68.70;

                if (nights > 14)
                {
                    priceStudio = priceStudio - 0.20 * priceStudio;
                }
            }

            else if (month == "July" || month == "August")
            {
                priceStudio = nights * 76;
                priceApartment = nights * 77;
            }

            if (nights > 14)
            {
                priceApartment = priceApartment - 0.10 * priceApartment;
            }

            Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
            
        }
    }
}
