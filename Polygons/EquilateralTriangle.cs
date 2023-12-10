

using System;

namespace Polygons
{
    public sealed class EquilateralTriangle : Triangle
    {
        private double _sideLength = 0;

        public double SideLength
        {
            get => _sideLength;


            set
            {
                if (value > 0)
                    _sideLength = value;
            }
        }
        public EquilateralTriangle(double sideLength) : base(s1: sideLength, s2: sideLength, s3: sideLength, isRegular: true)
        {
            SideLength = sideLength;
        }

        public override double Perimeter => SideLength * 3;

        public double AreaBySecondMethod => Math.Round(0.5*Math.Sin(Math.PI/3.0)*SideLength*SideLength ,2);
    }
}
