using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double price = squareMeters * 7.61;
            double discount = price * 0.18;
            double finalsum = price - discount;
            Console.WriteLine($"The final price is: {finalsum:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
