using System;

namespace _01.Numbers1to100
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            for (int i = num; i >= 1; i--)
            {
                Console.WriteLine(i); 
            }
            

        }
    }
}
