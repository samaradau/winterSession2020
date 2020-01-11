using System;
using YSamaradau_OOP_1.Shapes.Interfaces;

namespace YSamaradau_OOP_1.Shapes
{
    public class Polygon : IShape
    {
        public Point[] Tops { get; private set; }

        public Polygon(params Point[] tops)
        {
            Tops = tops;

            if (tops.Length < 3)
            {
                throw new ArgumentException(nameof(tops));
            }
        }

        public double GetTotalLength()
        {
            double result = 0;

            for (var i = Tops.Length - 1; i >= 1; i--)
            {
                var currentLength = Tops[i].GetLength(Tops[i - 1]);
                result += currentLength;
            }

            return result;
        }

        public override string ToString()
        {
            return nameof(Polygon);
        }
    }
}
