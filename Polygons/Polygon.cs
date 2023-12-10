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



        public Polygon(int numberOfSides, bool isRegular)
        {
            _numberOfSides = numberOfSides;
            _isRegular = isRegular;
        }
        public Polygon(int numberOfSides): this(numberOfSides, true)
        {

        }

        public double CalculateTotalAngle()
        {
            return (_numberOfSides - 2) * 180.0;
        }
        public double CalculateRegularAngle()
        {
            return (_isRegular)? CalculateTotalAngle() : -1 ;
        }
    }
}
