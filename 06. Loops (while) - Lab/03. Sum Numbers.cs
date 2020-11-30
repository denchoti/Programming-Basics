using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "Stop")
            {
                sum += double.Parse(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
