using System;

namespace _07AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double quantityBeer = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityRakia = double.Parse(Console.ReadLine());
            double quantityWhiskey = double.Parse(Console.ReadLine());

            double priceRakia = priceWhiskey / 2;
            double sumRakia = quantityRakia * priceRakia;

            double priceBeer = priceRakia - 0.8 * priceRakia;
            double sumBeer = quantityBeer * priceBeer;

            double priceWine = priceRakia - 0.4 * priceRakia;
            double sumWine = quantityWine * priceWine;

            double sumWhiskey = quantityWhiskey * priceWhiskey;

            double totalSum = sumBeer + sumWine + sumRakia + sumWhiskey;

            Console.WriteLine($"{totalSum:f2}");


        }
    }
}
