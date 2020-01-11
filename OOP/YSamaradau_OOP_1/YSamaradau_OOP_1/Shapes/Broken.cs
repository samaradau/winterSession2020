using System;
using System.Collections.Generic;
using YSamaradau_OOP_1.Shapes.Interfaces;

namespace YSamaradau_OOP_1.Shapes
{
    public class Broken : IShape
    {
        public Point[] Points { get; private set; }

        public Broken(params Point[] points)
        {
            Points = points;

            if (points.Length < 3)
            {
                throw new ArgumentException(nameof(points));
            }
        }

        public double GetTotalLength()
        {
            double result = 0;

            for (var i = Points.Length - 1; i >= 1; i--)
            {
                var currentLength = Points[i].GetLength(Points[i - 1]);
                result += currentLength;
            }

            return result;
        }

        public override string ToString()
        {
            return nameof(Broken);
        }
    }
}
