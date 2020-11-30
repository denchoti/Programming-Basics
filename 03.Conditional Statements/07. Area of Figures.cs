using System;

namespace _13._AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var sideSquare = double.Parse(Console.ReadLine());
                var areaSquare = sideSquare * sideSquare;
                Console.WriteLine($"{areaSquare:F3}");
            }

           else if (figure == "rectangle")
            {
                var sideRectangle1 = double.Parse(Console.ReadLine());
                var sideRectangle2 = double.Parse(Console.ReadLine());
                var areaRectangle = sideRectangle1 * sideRectangle2;
                Console.WriteLine($"{areaRectangle:F3}");
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                var areaCircle = Math.PI * radius * radius;
                Console.WriteLine($"{areaCircle:F3}");
            }

            else if (figure == "triangle")
            {
                var sideTriangle = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var areaTriangle = (sideTriangle / 2) * h;
                Console.WriteLine($"{areaTriangle:F3}");
            }
        }
    }
}
