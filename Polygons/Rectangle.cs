namespace Polygons
{
    public class Rectangle : Polygon
    {
        private double _length = 0;
        private double _width = 0;

        public double Length
        {
            get => _length;
            set
            {
                if(value > 0)
                    _length = value;
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                if(value > 0)
                    _width = value;
            }
        }

        public override double Area => Length * Width;

        public override double Perimeter => 2*(Length+Width) ;

        public Rectangle(double length, double width): base(numberOfSides:4, false)
        {
            Length = length;
            Width = width;
        }


    }
}
