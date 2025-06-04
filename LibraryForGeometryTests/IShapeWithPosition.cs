namespace LibraryForGeometryTests
{
    public interface IShapeWithPosition : IShape
    {
        Point Position { get; }
    }
}