using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJudges = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            double totalSum = 0;
            int countGrades = 0;

            while (text != "Finish")
            {
                
                double sum = 0;

                for (int judge = 1; judge <= countJudges; judge++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    totalSum += grade;
                    countGrades++;
                }

                double average = sum / countJudges;

                Console.WriteLine($"{text} - {average:F2}.");

                text = Console.ReadLine();
            }
            double averageAll = totalSum / countGrades;
            Console.WriteLine($"Student's final assessment is {averageAll:f2}."); 
        }
    }
}
