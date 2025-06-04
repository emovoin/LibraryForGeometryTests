# Юнит-тесты для библиотеки GeometryLib

## 1. Тесты для Point

| Название | Цель |
|---------|------|
| PointsWithSameCoordinates_AreEqual | Сравнение на равенство |
| PointsWithDifferentCoordinates_AreNotEqual | Проверка неравенства |
| NullPoint_ThrowsException | Проверка обработки null |
| PointToString_ReturnsCorrectFormat | Проверка метода ToString() |

## 2. Тесты для BoundingBox

| Название | Цель |
|---------|------|
| BoundingBox_Center_CalculatesCorrectly | Проверка центра |
| BoundingBox_IntersectingBoxes_ReturnsTrue | Проверка пересечения |
| BoundingBox_NonIntersectingBoxes_ReturnsFalse | Проверка отсутствия пересечения |
| BoundingBox_EqualBoxes_ReturnsTrue | Совпадающие прямоугольники |
| BoundingBox_EmptyBox_ThrowsOrHandlesGracefully | Обработка пустого прямоугольника |

## 3. Тесты для Circle

| Название | Цель |
|---------|------|
| Circle_GetArea_CorrectValue | Площадь круга |
| Circle_GetPerimeter_CorrectValue | Периметр круга |
| Circle_NegativeRadius_ThrowsException | Проверка валидации радиуса |
| Circle_Position_SetCorrectly | Проверка координат |
| Circle_NullPosition_ThrowsException | Обработка null-позиции |

## 4. Тесты для Rectangle

| Название | Цель |
|---------|------|
| Rectangle_GetArea_CorrectValue | Площадь прямоугольника |
| Rectangle_GetPerimeter_CorrectValue | Периметр прямоугольника |
| Rectangle_ZeroWidth_ThrowsException | Проверка ширины |
| Rectangle_ZeroHeight_ThrowsException | Проверка высоты |
| Rectangle_Position_SetCorrectly | Проверка координат |
| Rectangle_NullPosition_ThrowsException | Обработка null-позиции |

## 5. Тесты для Triangle

| Название | Цель |
|---------|------|
| Triangle_GetArea_CorrectForValidSides | Площадь треугольника |
| Triangle_InvalidSides_ThrowsException | Проверка допустимости сторон |
| Triangle_GetPerimeter_CorrectValue | Периметр треугольника |
| Triangle_Position_SetCorrectly | Проверка координат |
| Triangle_NullPosition_ThrowsException | Обработка null-позиции |

## 6. Тесты для Polygon

| Название | Цель |
|---------|------|
| Polygon_Empty_GetAreaReturnsZero | Площадь пустого многоугольника |
| Polygon_Empty_GetPerimeterReturnsZero | Периметр пустого многоугольника |
| Polygon_AddShape_IncreasesTotalArea | Добавление фигуры увеличивает площадь |
| Polygon_RemoveShape_DecreasesTotalArea | Удаление фигуры уменьшает площадь |
| Polygon_GetBoundingBox_CalculatesCorrectBounds | Проверка ограничивающего прямоугольника |
| Polygon_AddNullShape_ThrowsException | Обработка добавления null |
| Polygon_RemoveNullShape_ThrowsException | Обработка удаления null |
| Polygon_HasIntersection_ReturnsTrue_WhenOverlapping | Проверка пересечения (есть пересечение) |
| Polygon_HasIntersection_ReturnsFalse_WhenNoOverlap | Проверка пересечения (нет пересечения) |
| Polygon_HasIntersection_SingleShape_ReturnsFalse | Проверка для одной фигуры |
| Polygon_HasIntersection_Empty_ReturnsFalse | Проверка для пустого полигона |

## 7. Дополнительные тесты (по желанию)

| Название | Цель |
|---------|------|
| Polygon_GetBoundingBox_ForMixedShapes_Correct | Bounding Box для разных фигур |
| Polygon_GetBoundingBox_AfterRemove_UpdatesCorrectly | Изменение после удаления |
| Polygon_GetCenter_CalculatesFromBoundingBox | Проверка свойства Position |