namespace Polygons
{
    public abstract class Polygon {

        private readonly int _numberOfSides;

        private readonly bool _isRegular = true;

        public int NumberOfSides
        {
            get { return _numberOfSides; }
        }

        public bool IsRegular
        {
            get => _isRegular;
        }

        public abstract double Area
        {
            get;
        }
        
        public abstract double Perimeter
        {
            get;
        }



        Polygon(int numberOfSides, bool isRegular)
        {
            _numberOfSides = numberOfSides;
            _isRegular = isRegular;
        }
        Polygon(int numberOfSides): this(numberOfSides, true)
        {

        }
    }
}
