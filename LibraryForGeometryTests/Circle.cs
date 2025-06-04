namespace LibraryForGeometryTests
{
    public class Circle : IShapeWithPosition
    {
        public double Radius { get; }
        public Point Position { get; }

        public Circle(Point position, double radius)
        {
            if (radius < 0)
                throw new ArgumentException(nameof(radius));

            Position = position ?? throw new ArgumentNullException(nameof(position));
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            Circle other = obj as Circle;

            return Radius.Equals(other.Radius) && Position.Equals(other.Position);
        }

    }
}