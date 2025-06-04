using NUnit.Framework;
using System;
using LibraryForGeometryTests;

namespace LibraryForGeometryTests.Tests
{
    [TestFixture]
    public class CircleTests
    {
        private Point _center;

        [SetUp]
        public void SetUp()
        {
            _center = new Point(1.0, 2.0);
        }

        [Test]
        public void Circle_GetArea_CorrectValue()
        {

            double radius = 3.0;
            var circle = new Circle(_center, radius);


            double area = circle.GetArea();


            Assert.AreEqual(Math.PI * radius * radius, area, 1e-6,
                "Метод GetArea() должен возвращать π*r^2.");
        }

        [Test]
        public void Circle_GetPerimeter_CorrectValue()
        {

            double radius = 2.5;
            var circle = new Circle(_center, radius);

            double perimeter = circle.GetPerimeter();


            Assert.AreEqual(2.0 * Math.PI * radius, perimeter, 1e-6,
                "Метод GetPerimeter() должен возвращать 2πr.");
        }

        [Test]
        public void Circle_NegativeRadius_ThrowsException()
        {

            double badRadius = -1.0;


            Assert.Throws<ArgumentException>(
                () => new Circle(_center, badRadius),
                "Конструктор Circle с отрицательным radius должен бросать ArgumentException.");
        }

        [Test]
        public void Circle_Position_SetCorrectly()
        {
            
            double radius = 4.0;
            var circle = new Circle(_center, radius);


            var pos = circle.Position;

 
            Assert.AreEqual(_center, pos, "Свойство Position должно возвращать центр окружности.");
        }

        [Test]
        public void Circle_NullPosition_ThrowsException()
        {

            Assert.Throws<ArgumentNullException>(
                () => new Circle(null, 5.0),
                "Конструктор Circle при null-центре должен бросать ArgumentNullException.");
        }
    }
}