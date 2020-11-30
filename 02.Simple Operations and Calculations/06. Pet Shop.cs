using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogNumber = int.Parse(Console.ReadLine());
            int othersNumber = int.Parse(Console.ReadLine());
            double dogFood = 2.50;
            double othersFood = 4.00;
            double sum = (dogNumber * dogFood) + (othersNumber * othersFood);
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
