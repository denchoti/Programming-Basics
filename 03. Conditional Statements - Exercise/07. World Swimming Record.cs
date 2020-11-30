using System;

namespace _15.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double swimTime = distance * timePerMeter;
            double delayTime = Math.Floor(distance / 15) * 12.5;
            double totalTime = swimTime + delayTime;

            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                double secondsNeeded = totalTime - record; 
                Console.WriteLine($"No, he failed! He was {secondsNeeded:F2} seconds slower.");
            }
        }
    }
}
