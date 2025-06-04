using NUnit.Framework;
using System;
using LibraryForGeometryTests;

namespace LibraryForGeometryTests.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        private Point _a, _b, _c;

        [SetUp]
        public void SetUp()
        {

            _a = new Point(0, 0);
            _b = new Point(4, 0);
            _c = new Point(0, 3);
        }

        [Test]
        public void Triangle_GetArea_CorrectForValidSides()
        {

            var triangle = new Triangle(new Point(1, 1), 3.0, 4.0, 5.0);


            double area = triangle.GetArea();


            Assert.AreEqual(6.0, area, 1e-6, "Площадь треугольника со сторонами 3,4,5 должна быть 6.");
        }

        [Test]
        public void Triangle_InvalidSides_ThrowsException()
        {

            double a = 1.0, b = 2.0, c = 3.0; 
            var position = new Point(0, 0);


            Assert.Throws<ArgumentException>(
                () => new Triangle(position, a, b, c),
                "Конструктор Triangle для невалидных сторон должен бросать ArgumentException.");
        }

        [Test]
        public void Triangle_GetPerimeter_CorrectValue()
        {

            var triangle = new Triangle(new Point(0, 0), 3.0, 4.0, 5.0);


            double per = triangle.GetPerimeter();


            Assert.AreEqual(12.0, per, 1e-6, "Периметр треугольника со сторонами 3,4,5 должен быть 12.");
        }

        [Test]
        public void Triangle_Position_SetCorrectly()
        {

            var pos = new Point(2, 2);
            var triangle = new Triangle(pos, 3.0, 4.0, 5.0);


            var position = triangle.Position;


            Assert.AreEqual(pos, position, "Свойство Position должно возвращать переданную точку.");
        }

        [Test]
        public void Triangle_NullPosition_ThrowsException()
        {

            Assert.Throws<ArgumentNullException>(
                () => new Triangle(null, 3.0, 4.0, 5.0),
                "Конструктор Triangle при position = null должен бросать ArgumentNullException.");
        }
    }
}