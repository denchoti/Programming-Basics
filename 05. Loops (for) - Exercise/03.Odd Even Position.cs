using System;

namespace _14.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sumOdd = 0;
            double sumEven = 0;
            double maxOdd = -1000000000.0;
            double maxEven = -1000000000.0;
            double minOdd = 1000000000.0;
            double minEven = 1000000000.0;

            //през всички числа от 1 до n позиция

            for (int numberPosition = 1; numberPosition <= n; numberPosition++)
            {
                double value = double.Parse(Console.ReadLine());

                //четна позиция
                if (numberPosition % 2 == 0)
                {
                    sumEven += value;
                    //проверка за макс
                    if (value > maxEven)
                    {
                        maxEven = value;
                    }
                    //проверка за мин
                    if (value < minEven)
                    {
                        minEven = value;
                    }


                }
                //нечетна позиция
                else
                {
                    sumOdd += value;
                    //проверка за макс
                    if (value > maxOdd)
                    {
                        maxOdd = value;
                    }
                    //проверка за мин
                    if (value < minOdd)
                    {
                        minOdd = value;
                    }
                }

            }


            //нечетни
            Console.WriteLine($"OddSum={sumOdd:F2},");
            if (minOdd == 1000000000.0)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={minOdd:F2},");
            }

            if (maxOdd == -1000000000.0)
            {
                Console.WriteLine("OddMax=No,");

            }
            else
            {
                Console.WriteLine($"OddMax={maxOdd:F2},");
            }

            //четни
            Console.WriteLine($"EvenSum={sumEven:F2},");
            if (minEven == 1000000000.0)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={minEven:F2},");
            }

            if (maxEven == -1000000000.0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={maxEven:F2}");
            }

        }
    }

 }
