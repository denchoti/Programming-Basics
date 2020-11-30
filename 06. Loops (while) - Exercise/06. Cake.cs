using System;

namespace _16.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double pieces = 0;
            string command = Console.ReadLine();
            double cake = a * b;
            while (command != "STOP")
            {
                pieces = double.Parse(command) + pieces;

                if (cake < pieces)
                {
                    Console.WriteLine($"No more cake left! You need {pieces - (a * b)} pieces more.");
                    return;
                }
                command = Console.ReadLine();
            }
            if (command == "STOP")
            {
                Console.WriteLine($"{cake - pieces} pieces are left.");
            }
        }
    }
}
