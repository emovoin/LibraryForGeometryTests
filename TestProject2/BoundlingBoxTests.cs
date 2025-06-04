using NUnit.Framework;
using System;
using LibraryForGeometryTests;

namespace LibraryForGeometryTests.Tests
{
    [TestFixture]
    public class BoundingBoxTests
    {
        private Point _bl;
        private Point _tr;

        [SetUp]
        public void SetUp()
        {
            _bl = new Point(0, 0);
            _tr = new Point(10, 10);
        }

        [Test]
        public void BoundingBox_Center_CalculatesCorrectly()
        {
            var box = new BoundingBox(_bl, _tr);

            var center = box.Center;

            Assert.AreEqual(new Point(5, 5), center, "Центр BoundingBox должен быть серединой (5,5).");
        }

        [Test]
        public void BoundingBox_IntersectingBoxes_ReturnsTrue()
        {
            var box1 = new BoundingBox(new Point(0, 0), new Point(5, 5));
            var box2 = new BoundingBox(new Point(4, 4), new Point(10, 10));

            bool intersects = box1.Intersects(box2);

            Assert.IsTrue(intersects, "Два пересекающихся BoundingBox должны возвращать true.");
        }

        [Test]
        public void BoundingBox_NonIntersectingBoxes_ReturnsFalse()
        {
            var box1 = new BoundingBox(new Point(0, 0), new Point(3, 3));
            var box2 = new BoundingBox(new Point(4, 4), new Point(8, 8));

            bool intersects = box1.Intersects(box2);

            Assert.IsFalse(intersects, "Непересекающиеся BoundingBox должны возвращать false.");
        }

        [Test]
        public void BoundingBox_EqualBoxes_ReturnsTrue()
        {
            var box1 = new BoundingBox(new Point(1, 2), new Point(5, 6));
            var box2 = new BoundingBox(new Point(1, 2), new Point(5, 6));

            bool intersects = box1.Intersects(box2);

            Assert.IsTrue(intersects, "Идентичные BoundingBox считаются пересекающимися.");
        }

        [Test]
        public void BoundingBox_EmptyBox_ThrowsException()
        {
            Assert.Throws<ArgumentException>(
                () => new BoundingBox(new Point(5, 5), new Point(2, 2)),
                "Конструктор пустого/некорректного BoundingBox должен бросать ArgumentException.");
        }
    }
}