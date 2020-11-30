using System;

namespace _14.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceTotal = 0;

            switch (flower)
            {

                case "Roses":
                    priceTotal = flowerCount * 5;
                    if (flowerCount > 80)
                    {
                        priceTotal = priceTotal * 0.9;
                    }
                    break;

                case "Dahlias":

                    priceTotal = flowerCount * 3.80;
                    if (flowerCount > 90)
                    {
                        priceTotal = priceTotal * 0.85;
                    }
                    break;

                case "Tulips":
                    priceTotal = flowerCount * 2.80;
                    if (flowerCount > 80)
                    {
                        priceTotal = priceTotal * 0.85;
                    }
                    break;

                case "Narcissus":
                    priceTotal = flowerCount * 3;
                    if (flowerCount < 120)
                    {
                        priceTotal = priceTotal + (priceTotal * 0.15);
                    }
                    break;

                case "Gladiolus":
                    priceTotal = flowerCount * 2.50;
                    if (flowerCount < 80)
                    {
                        priceTotal = priceTotal + (priceTotal  * 0.20);
                    }
                    break;

            }
  
            double enough = budget - priceTotal;
            double notEnough = priceTotal - budget;

            if (budget >= priceTotal)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flower} and {enough:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {notEnough:F2} leva more.");
            }


        }
    }
}
