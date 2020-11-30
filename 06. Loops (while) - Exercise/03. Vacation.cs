using System;

namespace _13.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());


            int countSpendDays = 0;
            int countTotalDays = 0;

            while (availableMoney < tripPrice)
            {
                string action = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                countTotalDays++;

                if (action == "save")
                {
                    availableMoney += price;
                    countSpendDays = 0;
                }
                else if (action == "spend")
                {
                    countSpendDays++;
                    availableMoney -= price;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }


                if (countSpendDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(countTotalDays);
                    break;
                }

            }

            
            if (availableMoney >= tripPrice)
            {
                Console.WriteLine($"You saved the money for {countTotalDays} days.");
            }
        }
    }
}
