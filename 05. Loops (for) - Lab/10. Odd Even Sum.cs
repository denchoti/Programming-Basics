using System;
using System.Security.Cryptography;

namespace _10._OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int number = 0; number < n; number++)
            {
                int x = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    evenSum+= x;
                }
                else
                {
                    oddSum += x;
                }

            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = " + evenSum);
            }
            else
            {
                int diff = oddSum - evenSum;
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(diff));
            }
        }
    }
}
