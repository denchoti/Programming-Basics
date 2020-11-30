using System;

namespace _09._LeftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;

            for (int number = 0; number < n; number++)
            {
                int x = int.Parse(Console.ReadLine());
                firstSum = firstSum + x;
            }

            for (int number = 0; number < n; number++)
            {
                int y = int.Parse(Console.ReadLine());
                secondSum = secondSum + y;
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum = " + firstSum);
            }

            else
            {
                int diff = firstSum - secondSum;
                if (diff < 0)
                    diff = Math.Abs(diff);
                Console.WriteLine("No, diff = " + diff);

            }
        }
    }
}
