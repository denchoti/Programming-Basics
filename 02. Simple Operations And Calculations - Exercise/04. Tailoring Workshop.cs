using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
     
            int numberTables = int.Parse(Console.ReadLine());
            double lengthTables = double.Parse(Console.ReadLine());
            double widthTables = double.Parse(Console.ReadLine());

            double areaTables = numberTables * (lengthTables + 2 * 0.30) * (widthTables + 2 * 0.30);
            double areaQuads = numberTables * (lengthTables / 2) * (lengthTables / 2);

            double sumUSD = areaTables * 7 + areaQuads * 9;
            double sumBGN = sumUSD * 1.85;

            Console.WriteLine($"{sumUSD:F2} USD");
            Console.WriteLine($"{sumBGN:F2} BGN");

        }
    }
}
