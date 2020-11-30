using System;

namespace _09.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            
            int seconds = num1 + num2 + num3;
            int minutes = seconds / 60;
            seconds = seconds % 60;

            if (seconds >= 60)
            {
                seconds = seconds - 60;
                minutes = minutes + 1;
            }

            if (seconds >= 60)
            {
                seconds = seconds - 60;
                minutes = minutes + 1;
            }

            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }

            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }

        }
    }
}
