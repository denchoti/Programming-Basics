using System;

namespace _09.Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string name = Console.ReadLine();
            int currentClass = 1;
            double totalGrades = 0;
            int fails = 0;

            while (currentClass <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    totalGrades += grade;
                    currentClass++;
                }
                else
                {
                    fails += 1;

                }

                if (fails > 1)
                {

                    Console.WriteLine($"{name} has been excluded at {currentClass} grade");
                    break;
                }
            }


            if (fails < 1)
            {
                double averageGrade = totalGrades / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
            }


        }
    }
}
