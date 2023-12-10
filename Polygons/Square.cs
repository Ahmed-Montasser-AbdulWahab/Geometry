namespace Polygons
{
    public sealed class Square : Polygon
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

        public Square(double sideLength) : base(4)
        {
            SideLength = sideLength;
        }
        public override double Area => SideLength * SideLength;

        public override double Perimeter => SideLength * 4;
    }
}
