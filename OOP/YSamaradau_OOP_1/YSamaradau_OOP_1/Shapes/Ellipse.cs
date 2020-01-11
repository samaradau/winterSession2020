using System;
using YSamaradau_OOP_1.Shapes.Interfaces;

namespace YSamaradau_OOP_1.Shapes
{
    public class Ellipse : IShape
    {
        public Lazy<double> HalfShaftA
        {
            get
            {
                return new Lazy<double>(() => EllipseCenter.GetLength(HalfShaftAEnd));
            }
        }

        public Lazy<double> HalfShaftB
        {
            get
            {
                return new Lazy<double>(() => EllipseCenter.GetLength(HalfShaftBEnd));
            }
        }

        public Point EllipseCenter { get; private set; }

        public Point HalfShaftAEnd { get; private set; }

        public Point HalfShaftBEnd { get; private set; }


        public Ellipse(Point ellipseCenter, Point halfShaftAEnd, Point halfShaftBEnd)
        {
            EllipseCenter = ellipseCenter;
            HalfShaftAEnd = halfShaftAEnd;
            HalfShaftBEnd = halfShaftBEnd;
        }

        public double GetTotalLength()
        {
            var result = Math.PI * (HalfShaftA.Value + HalfShaftB.Value);
            return result;
        }

        public override string ToString()
        {
            return nameof(Ellipse);
        }
    }
}
