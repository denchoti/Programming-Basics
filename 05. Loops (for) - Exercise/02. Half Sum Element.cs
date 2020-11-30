using System;

namespace _13.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = 0;


            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum = sum + num;

                if (num > max)
                {
                    max = num;
                }
            }
            var sum2 = sum - max;
            if (max == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum2);
            }
            else
            {
                var diff = Math.Abs(sum2 - max);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
