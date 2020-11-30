using System;

namespace _01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int n = 0;

            while (input != "Stop")
            {
                n++;
                input = Console.ReadLine();
                
            }
            Console.WriteLine(n);
        }
    }
}
