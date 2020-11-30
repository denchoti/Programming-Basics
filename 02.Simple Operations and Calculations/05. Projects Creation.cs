using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectsnumber = int.Parse(Console.ReadLine());
            int time = projectsnumber * 3;
            Console.WriteLine($"The architect {name} will need {time} hours to complete {projectsnumber} project/s.");
        }
    }
}
