namespace LibraryForGeometryTests
{
    public class Triangle : IShapeWithPosition
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public Point Position { get; }

        public Triangle(Point position, double a, double b, double c)
        {
            if (position == null)
                throw new ArgumentNullException("position");
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("длинны меньше 0");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("сумма меньше 3");

            Position = position ?? throw new ArgumentNullException(nameof(position));
            A = a;
            B = b;
            C = c;
        }
        

        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public double GetPerimeter()
        {
            return A + B + C;
        }

    }
}