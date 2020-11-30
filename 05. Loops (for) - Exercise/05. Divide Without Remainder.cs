using System;

namespace _16.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value % 2 == 0)
                {
                    group1 += 1;
                    //group1++;
                }
                if (value % 3 ==0)
                {
                    group2 += 1;
                }
                if (value % 4 == 0)
                {
                    group3 += 1;
                    
                }
            }

            double percent1 = group1 * 1.0 / n * 100;
            double percent2 = group2 * 1.0 / n * 100;
            double percent3 = group3 * 1.0 / n * 100;

            Console.WriteLine($"{percent1:F2}%");
            Console.WriteLine($"{percent2:F2}%");
            Console.WriteLine($"{percent3:F2}%");
        }
    }
}
