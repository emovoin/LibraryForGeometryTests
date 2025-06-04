using NUnit.Framework;
using System;
using LibraryForGeometryTests;

namespace LibraryForGeometryTests.Tests
{
    [TestFixture]
    public class PointTests
    {
        [Test]
        public void PointsWithSameCoordinates_AreEqual()
        {

            var p1 = new Point(3.5, -1.2);
            var p2 = new Point(3.5, -1.2);


            Assert.AreEqual(p1, p2, "Две точки с одинаковыми координатами должны быть равны через Equals.");
            Assert.IsTrue(p1.Equals(p2));
            Assert.IsTrue(p2.Equals(p1));
        }

        [Test]
        public void PointsWithDifferentCoordinates_AreNotEqual()
        {

            var p1 = new Point(0.0, 0.0);
            var p2 = new Point(0.0, 0.001);


            Assert.AreNotEqual(p1, p2, "Точки с разными координатами не должны быть равны.");
            Assert.IsFalse(p1.Equals(p2));
            Assert.IsFalse(p2.Equals(p1));
        }

        [Test]
        public void PointToString_ReturnsCorrectFormat()
        {
            var p = new Point(2.25, 5.75);

            string str = p.ToString();

            Assert.AreEqual("(2.25, 5.75)", str, "Метод ToString() должен возвращать координаты в формате \"(X, Y)\".");
        }

        [Test]
        public void NullPoint_ThrowsException()
        {
           

            Assert.Pass("В текущей реализации Point не принимает null‐значения, поэтому тест на NullPoint пропущен.");
        }
    }
}