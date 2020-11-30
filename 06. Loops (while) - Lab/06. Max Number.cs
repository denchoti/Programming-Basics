using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            int i = 0;

            while (i < n)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > max)
                {
                    max = currentNumber;
                }

                i++;

            }

            Console.WriteLine(max);
        }
    }
}
