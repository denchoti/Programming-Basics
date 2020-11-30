using System;

namespace _11.Books
{
    class Program
    {
        static void Main(string[] args)
        {

            string searchedBook = Console.ReadLine();
            int countTotalBooks = int.Parse(Console.ReadLine());

            int countCheckedBooks = 0;

            while (countTotalBooks > 0)
            {
                string title = Console.ReadLine();
                if (title == searchedBook)
                {
                    
                    Console.WriteLine($"You checked {countCheckedBooks} books and found it.");
                    break;
                }
                else
                {
                    
                    countCheckedBooks++;
                }

                countTotalBooks--;
            }

            if (countTotalBooks <= 0)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countCheckedBooks} books.");
            }




        }
    }
}
