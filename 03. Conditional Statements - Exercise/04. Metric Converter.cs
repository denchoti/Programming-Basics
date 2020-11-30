using System;

namespace _12.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string sourceMetric = Console.ReadLine();
            string destMetric = Console.ReadLine();

            if (sourceMetric == "mm" && destMetric == "cm")
            {
                number = number / 10;
            }
            else if (sourceMetric == "mm" && destMetric == "m")
            {
                number = number / 1000.0;
            }
            else if (sourceMetric == "cm" && destMetric == "mm")
            {
                number = number * 10;
            }
            else if (sourceMetric == "cm" && destMetric == "m")
            {
                number = number / 100.00;
            }
            else if (sourceMetric == "m" && destMetric == "mm")
            {
                number = number * 1000;
            }
            else if (sourceMetric == "m" && destMetric == "cm")
            {
                number = number * 100;
            }
            Console.WriteLine($"{number:F3}");


        }
    }
}
