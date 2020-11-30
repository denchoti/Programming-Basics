using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;
            double liters = volume * 0.001;
            double percent2 = (percent*liters) / 100;
            double possibleLiters = liters - percent2;
            Console.WriteLine($"{possibleLiters:f3}");
        }
    }
}
