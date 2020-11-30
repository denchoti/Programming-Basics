using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value >= max)
                {
                    max = value;
                }
                if (value <= min)
                {
                    min = value;
                }

            }
            Console.WriteLine("Max number: " + max);
            Console.WriteLine("Min number: " + min);
        }
    }
}
