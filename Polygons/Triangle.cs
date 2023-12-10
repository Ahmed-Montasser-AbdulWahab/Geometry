

using System;

namespace Polygons
{
    public class Triangle : Polygon
    {
        private double[] sideLengths = new double[3];


        protected Triangle(double s1, double s2, double s3, bool isRegular) : base(3, isRegular)
        {
            sideLengths[0] = s1;
            sideLengths[1] = s2;
            sideLengths[2] = s3;
        }
        public Triangle(double s1, double s2, double s3) : base(3, false)
        {
            sideLengths[0] = s1;
            sideLengths[1] = s2;
            sideLengths[2] = s3;
        }

        public override double Perimeter => sideLengths[0] + sideLengths[1] + sideLengths[2];
        public override double Area //Heron's Formula
        {
            get
            {
                var halfPerimeter = Perimeter / 2;
                return Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - sideLengths[0]) * (halfPerimeter - sideLengths[1]) * (halfPerimeter - sideLengths[2])), 2);
            }
        }


    }
}
