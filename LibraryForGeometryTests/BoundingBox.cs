namespace LibraryForGeometryTests
{
    public class BoundingBox
    {
        public Point BottomLeft { get; }
        public Point TopRight { get; }
        public Point Center => new Point(
            (BottomLeft.X + TopRight.X) / 2,
            (BottomLeft.Y + TopRight.Y) / 2);

        public BoundingBox(Point bottomLeft, Point topRight)
        {
            if (bottomLeft == null)
                throw new ArgumentNullException(nameof(bottomLeft));
            if (TopRight == null)
                throw new ArgumentNullException(nameof(TopRight));
            if (bottomLeft.X > topRight.X || bottomLeft.Y > topRight.Y)
                throw new ArgumentException("пися");




            BottomLeft = bottomLeft;
            TopRight = topRight;
        }
        public bool Intersects(BoundingBox other)
        {
            return !(TopRight.X < other.BottomLeft.X ||
                     BottomLeft.X > other.TopRight.X ||
                     TopRight.Y < other.BottomLeft.Y ||
                     BottomLeft.Y > other.TopRight.Y);
        }

    }
}