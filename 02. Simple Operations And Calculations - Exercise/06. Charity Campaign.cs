using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDays = int.Parse(Console.ReadLine());
            int numberPastryCooks = int.Parse(Console.ReadLine());
            int numberCakes = int.Parse(Console.ReadLine());
            int numberWaffles = int.Parse(Console.ReadLine());
            int numberPancakes = int.Parse(Console.ReadLine());

            double sumCakes = numberCakes * 45;
            double sumWaffles = numberWaffles * 5.80;
            double sumPancakes = numberPancakes * 3.20;

            double sumDay = (sumCakes + sumWaffles + sumPancakes) * numberPastryCooks;
            double sumCollected = sumDay * numberDays;
            double sumFinal = sumCollected - (0.125 * sumCollected);

            Console.WriteLine($"{sumFinal:F2}");

        }
    }
}
