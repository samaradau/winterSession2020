using System;

namespace YSamaradau_OOP_1.Shapes
{
    public struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetLength(Point p)
        {
            var deltaX = Math.Pow(this.x - p.x, 2);
            var deltaY = Math.Pow(this.y - p.y, 2);

            return Math.Abs(Math.Sqrt(deltaX + deltaY));
        }
    }
}
