using System.Globalization;

namespace LibraryForGeometryTests
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X.ToString(CultureInfo.CreateSpecificCulture("en-GB"))}, {Y.ToString(CultureInfo.CreateSpecificCulture("en-GB"))})";

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            Point other = obj as Point;

            return X.Equals(other.X) && Y.Equals(other.Y);
        }
    }
}