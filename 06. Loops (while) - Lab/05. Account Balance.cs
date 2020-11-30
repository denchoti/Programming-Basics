using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int transactions = int.Parse(Console.ReadLine());
            double bankAccount = 0;

            for (int i = 0; i < transactions; i++)
            {
                double money = double.Parse(Console.ReadLine());

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                bankAccount += money;
                Console.WriteLine($"Increase: {money:F2}");
            }
            Console.WriteLine($"Total: {bankAccount:F2}");
        }
    }
}
