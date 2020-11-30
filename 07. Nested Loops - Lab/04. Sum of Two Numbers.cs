using System;

namespace _04.Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            bool numberFound = false;
            int combinations = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int j = firstNum; j <= secondNum; j++)
                {
                    combinations++;

                    if (i + j == magicNum)
                    {
                        numberFound = true;
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNum})");
                        return;
                    }
                    
                }
            }
            if (!numberFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }

            
        }
    }
}
