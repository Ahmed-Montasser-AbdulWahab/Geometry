

using System;

namespace Polygons
{
    abstract class Triangle : Polygon
    {
        protected double[] sideLengths = new double[3];


        public Triangle(double s1, double s2, double s3, bool isRegular) : base(3, isRegular)
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
                return Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - sideLengths[0]) * (halfPerimeter - sideLengths[1]) * (halfPerimeter - sideLengths[2])),2);
            }
        }

        public double Area2
        {
            get
            {
                
                var height = Math.Pow(sideLengths[0],2)/sideLengths[2];
                return 0.5 * height * sideLengths[2] ;
            }
        }
    }
}
