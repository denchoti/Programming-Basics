using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int min = int.MaxValue;

            int i = 0;

            while (i < n)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber <= min)
                {
                    min = currentNumber;
                }

                i++;

            }

            Console.WriteLine(min);
        }
    }
}
