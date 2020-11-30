using System;
using System.Threading;

namespace _3.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

          //или число ("3"), или думата stop
          //стоп: command == stop
          //продължаваме: command != stop

            //сума на прости -> делят се на себе си и на 1 (2 делителя)
            //сума на съставни -> > 2 делителя
            int sumPrime = 0;
            int sumNoPrime = 0;
            while (command != "stop")
            {
                //число под формата на текст -> command = "5" -> 5
                int number = int.Parse(command);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    //проверка дали е просто или съставно
                    int count = 0; //броят на делителите
                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            count++;
                        }

                    }
                    //броят на делителите
                    if (count == 2)
                    {
                        //просто число
                        sumPrime += number;
                    }
                    else if (count > 2)
                    {
                        //съставно число
                        sumNoPrime += number;

                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNoPrime}");
        }
    }
}
