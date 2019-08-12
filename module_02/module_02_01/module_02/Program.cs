using System;
using module_02.Library;

namespace module_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPoligon("Square", square);

            var triangle = new Triangle(5);
            DisplayPoligon("Triangle", triangle);

            var octagon = new Octagon(5);
            DisplayPoligon("Octagon", octagon);
        }

        public static void DisplayPoligon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine($"{polygonType} Number of Sides: {polygon.NumberOfSides}");
                Console.WriteLine($"{polygonType} Side Length: {polygon.SideLength}");
                Console.WriteLine($"{polygonType} Perimeter: {polygon.GetPerimeter()}");
                Console.WriteLine($"{polygonType} Area: {Math.Round(polygon.GetArea(), 2)}");
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine(
                    $"Exception was thrown while trying to process {polygonType}:\n");
                Console.WriteLine();
            }
        }
    }
}
