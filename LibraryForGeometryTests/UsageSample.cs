using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForGeometryTests
{
    public class UsageSample
    {
        public void Polygon()
        {
            StringBuilder sb = new();
            // Создаем несколько фигур с координатами
            var circle = new Circle(new Point(0, 0), radius: 2);
            var rectangle = new Rectangle(new Point(5, 1), width: 4, height: 3);
            var triangle = new Triangle(new Point(2, 5), a: 3, b: 4, c: 5);

            // Создаем многоугольник и добавляем в него фигуры
            var polygon = new Polygon();
            polygon.AddShape(circle);
            polygon.AddShape(rectangle);
            polygon.AddShape(triangle);

            // Выводим информацию о многоугольнике
            sb.AppendLine($"Общая площадь: {polygon.GetArea():F2}");
            sb.AppendLine($"Общий периметр: {polygon.GetPerimeter():F2}");

            var boundingBox = polygon.GetBoundingBox();
            sb.AppendLine($"Bounding Box:");
            sb.AppendLine($"Bottom Left: {boundingBox.BottomLeft}");
            sb.AppendLine($"Top Right: {boundingBox.TopRight}");
            sb.AppendLine($"Center: {boundingBox.Center}");
        }
    }
}
