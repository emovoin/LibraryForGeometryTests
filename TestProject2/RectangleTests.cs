using NUnit.Framework;
using System;
using LibraryForGeometryTests;

namespace LibraryForGeometryTests.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        private Point _pos;

        [SetUp]
        public void SetUp()
        {
            _pos = new Point(2.0, 3.0);
        }

        [Test]
        public void Rectangle_GetArea_CorrectValue()
        {

            double width = 4.0, height = 5.0;
            var rect = new Rectangle(_pos, width, height);


            double area = rect.GetArea();


            Assert.AreEqual(width * height, area, 1e-6,
                "Метод GetArea() прямоугольника должен возвращать width*height.");
        }

        [Test]
        public void Rectangle_GetPerimeter_CorrectValue()
        {

            double width = 3.5, height = 2.5;
            var rect = new Rectangle(_pos, width, height);


            double per = rect.GetPerimeter();


            Assert.AreEqual(2.0 * (width + height), per, 1e-6,
                "Метод GetPerimeter() должен возвращать 2*(width + height).");
        }

        [Test]
        public void Rectangle_ZeroWidth_ThrowsException()
        {

            Assert.Throws<ArgumentException>(
                () => new Rectangle(_pos, 0.0, 5.0),
                "Конструктор Rectangle с width = 0 должен бросать ArgumentException.");
        }

        [Test]
        public void Rectangle_ZeroHeight_ThrowsException()
        {

            Assert.Throws<ArgumentException>(
                () => new Rectangle(_pos, 4.0, 0.0),
                "Конструктор Rectangle с height = 0 должен бросать ArgumentException.");
        }

        [Test]
        public void Rectangle_Position_SetCorrectly()
        {

            double width = 2.0, height = 3.0;
            var rect = new Rectangle(_pos, width, height);


            var pos = rect.Position;


            Assert.AreEqual(_pos, pos, "Свойство Position должно возвращать нижний левый угол.");
        }

        [Test]
        public void Rectangle_NullPosition_ThrowsException()
        {

            Assert.Throws<ArgumentNullException>(
                () => new Rectangle(null, 4.0, 5.0),
                "Конструктор Rectangle при position = null должен бросать ArgumentNullException.");
        }
    }
}