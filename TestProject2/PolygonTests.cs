using NUnit.Framework;
using System;
using LibraryForGeometryTests;

namespace LibraryForGeometryTests.Tests
{
    [TestFixture]
    public class PolygonTests
    {
        private Polygon _polygon;

        [SetUp]
        public void SetUp()
        {
            _polygon = new Polygon();
        }

        [Test]
        public void Polygon_Empty_GetAreaReturnsZero()
        {
            Assert.AreEqual(0.0, _polygon.GetArea(), 1e-6,
                "Площадь пустого Polygon должна быть 0.");
        }

        [Test]
        public void Polygon_Empty_GetPerimeterReturnsZero()
        {
            Assert.AreEqual(0.0, _polygon.GetPerimeter(), 1e-6,
                "Периметр пустого Polygon должен быть 0.");
        }

        [Test]
        public void Polygon_AddShape_IncreasesTotalArea()
        {
            var rect = new Rectangle(new Point(0, 0), 2.0, 3.0);
            var circle = new Circle(new Point(5, 5), 1.0);

            double areaBefore = _polygon.GetArea();

            _polygon.AddShape(rect);
            double areaAfterRect = _polygon.GetArea();
            _polygon.AddShape(circle);
            double areaAfterCircle = _polygon.GetArea();

            Assert.Greater(areaAfterRect, areaBefore,
                "После добавления прямоугольника площадь должна увеличиться.");
            Assert.AreEqual(areaAfterRect + Math.PI * 1.0 * 1.0, areaAfterCircle, 1e-6,
                "После добавления круга радиусом 1 площадь должна увеличиться на π.");
        }

        [Test]
        public void Polygon_RemoveShape_DecreasesTotalArea()
        {
            var rect = new Rectangle(new Point(0, 0), 2.0, 3.0);  
            var circle = new Circle(new Point(5, 5), 1.0);        
            _polygon.AddShape(rect);
            _polygon.AddShape(circle);

            double areaBefore = _polygon.GetArea();

            _polygon.RemoveShape(rect);
            double areaAfter = _polygon.GetArea();

            Assert.Less(areaAfter, areaBefore,
                "После удаления прямоугольника площадь должна уменьшиться.");
            Assert.AreEqual(areaBefore - rect.GetArea(), areaAfter, 1e-6,
                "После удаления прямоугольника 2x3 площадь должна уменьшиться ровно на 6.");
        }

   

        [Test]
        public void Polygon_AddNullShape_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(
                () => _polygon.AddShape(null),
                "Добавление null‐фигуры должно бросать ArgumentNullException.");
        }

        [Test]
        public void Polygon_RemoveNullShape_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(
                () => _polygon.RemoveShape(null),
                "Удаление null‐фигуры должно бросать ArgumentNullException.");
        }

        [Test]
        public void Polygon_HasIntersection_ReturnsTrue_WhenOverlapping()
        {
            var polyA = new Polygon();
            var polyB = new Polygon();

            var circleA = new Circle(new Point(0, 0), 2.0);
            var circleB = new Circle(new Point(1, 1), 2.0);

            polyA.AddShape(circleA);
            polyB.AddShape(circleB);

            bool intersects = polyA.HasIntersection(polyB);

            Assert.IsTrue(intersects,
                "Два полигона с пересекающимися кругами должны вернуть true.");
        }

        [Test]
        public void Polygon_HasIntersection_ReturnsFalse_WhenNoOverlap()
        {
            var polyA = new Polygon();
            var polyB = new Polygon();

            var circleA = new Circle(new Point(0, 0), 1.0);
            var circleB = new Circle(new Point(5, 5), 1.0);

            polyA.AddShape(circleA);
            polyB.AddShape(circleB);

            bool intersects = polyA.HasIntersection(polyB);

            Assert.IsFalse(intersects,
                "Два полигона с непересекающимися кругами должны вернуть false.");
        }

        [Test]
        public void Polygon_HasIntersection_SingleShape_ReturnsFalse()
        {
            var polyA = new Polygon();
            var circleA = new Circle(new Point(0, 0), 1.0);
            polyA.AddShape(circleA);

            bool intersects = polyA.HasIntersection(polyA);

            Assert.IsFalse(intersects,
                "Полигон, сравниваемый сам с собой, должен вернуть false.");
        }

        [Test]
        public void Polygon_HasIntersection_Empty_ReturnsFalse()
        {
            var polyA = new Polygon();
            var polyB = new Polygon();

            bool intersects = polyA.HasIntersection(polyB);

            Assert.IsFalse(intersects,
                "Два пустых полигона не должны пересекаться.");
        }
    }
}