using System;

namespace _08.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            int numberPuzzles = int.Parse(Console.ReadLine());
            int numberDolls = int.Parse(Console.ReadLine());
            int numberTeddyBears = int.Parse(Console.ReadLine());
            int numberMinions = int.Parse(Console.ReadLine());
            int numberCars = int.Parse(Console.ReadLine());

            double pricePuzzles = 2.60;
            double priceDolls = 3.00;
            double priceTeddyBears = 4.10;
            double priceMinions = 8.20;
            double priceCars = 2.00;


            double sum = (numberPuzzles * pricePuzzles) + (numberDolls * priceDolls) +
                         (numberTeddyBears * priceTeddyBears) + (numberMinions * priceMinions) +
                         (numberCars * priceCars);
            double numberToys = numberPuzzles + numberDolls + numberTeddyBears + numberMinions + numberCars;

            if (numberToys >= 50)
            {
                sum = sum - 0.25 * sum;
            }
            sum = sum * 0.9;

            if (sum >= priceTrip)
            {
                Console.WriteLine($"Yes! {(sum - priceTrip):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(priceTrip - sum):F2} lv needed.");
            }

        }
    }
}

