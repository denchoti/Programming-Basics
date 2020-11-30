using System;

namespace _1.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentNum = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int numbersPerRow = 1; numbersPerRow <= row; numbersPerRow++)
                {
                    Console.Write(currentNum + " ");
                    currentNum++;

                    if (currentNum > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (currentNum > n)
                {
                    break;
                }

            }
        }
    }
}
