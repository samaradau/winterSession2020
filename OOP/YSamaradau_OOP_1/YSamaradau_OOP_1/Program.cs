using System;
using System.Collections.Generic;
using YSamaradau_OOP_1.Shapes;
using YSamaradau_OOP_1.Shapes.Interfaces;

namespace YSamaradau_OOP_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var shapes = new List<IShape>()
            {
                new Straight(new Point(5,5), new Point(7, 5)),
                new Broken(new Point(1, 2), new Point(2,3), new Point(3, 8)),
                new Ellipse(new Point(4, 4), new Point(5, 8), new Point(3, 1)),
                new Polygon(new Point(1, 2), new Point(2,3), new Point(3, 8))
            };

            foreach (var shape in shapes)
            {
                var result = Double.IsPositiveInfinity(shape.GetTotalLength()) 
                    ? "Positive Infinity" 
                    : shape.GetTotalLength().ToString();
                Console.WriteLine($"{shape} total length is {result}");
            }

            Console.ReadLine();
        }
    }
}
