using System;

namespace RadiansToDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degress = radians * 180 / Math.PI;
            Console.WriteLine(Math.Round(degress));
        }
    }
}
