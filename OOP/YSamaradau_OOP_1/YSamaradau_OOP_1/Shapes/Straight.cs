using System;
using YSamaradau_OOP_1.Shapes.Interfaces;

namespace YSamaradau_OOP_1.Shapes
{
    public class Straight : IShape
    {


        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public Straight(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public double GetTotalLength()
        {
            return Double.PositiveInfinity;
        }

        public override string ToString()
        {
            return nameof(Straight);
        }
    }
}
