using System;

namespace _13.TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 15 > 59)
            {
                hours += 1;
                minutes = 15 - (60 - minutes);
            }
            else if (minutes + 15 <= 59)

            {
                minutes += 15;
            }

            if (hours == 24)
            {
                hours = 0;
            }

            Console.WriteLine("{0}:{1:00}", hours, minutes);

        }
    }
}
