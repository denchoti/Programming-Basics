using System;

namespace _13.GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberStatists = int.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double clothes = numberStatists * priceClothes;
            
            if (numberStatists > 150)
            {
                clothes = clothes - 0.10 * clothes;
            }

            double expenses = decor + clothes;

            if (budget >= expenses)
            {
                Console.WriteLine("Action!");
                double moneyLeft = budget - expenses;
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
            if (expenses > budget)
            {
                Console.WriteLine("Not enough money!");
                double moneyNeeded = expenses - budget;
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
            }
        }
    }
}
