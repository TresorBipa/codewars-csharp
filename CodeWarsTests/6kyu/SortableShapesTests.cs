using System;
using System.Collections.Generic;
using System.Linq;
using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu;

[TestFixture]
public class SortableShapesTests
{
    [Test]
    public void ShapesAreSortableOnArea()
    {
        // Arrange
        double width, height, triangleBase, side, radius, area;
        Random random = new Random((int) DateTime.UtcNow.Ticks);

        var expected = new List<SortableShapes.Shape>();

        area = 1.1234;
        expected.Add(new SortableShapes.CustomShape(area));

        side = 1.1234;
        expected.Add(new SortableShapes.Square(side));

        radius = 1.1234;
        expected.Add(new SortableShapes.Circle(radius));

        triangleBase = 5;
        height = 2;
        expected.Add(new SortableShapes.Triangle(triangleBase, height));

        height = 3;
        triangleBase = 4;
        expected.Add(new SortableShapes.Triangle(triangleBase, height));

        width = 4;
        expected.Add(new SortableShapes.Rectangle(width, height));

        area = 16.1;
        expected.Add(new SortableShapes.CustomShape(area));

        var actual = expected.OrderBy(x => random.Next()).ToList();

        // Act
        actual.Sort();

        // Assert
        for (var i = 0; i < 5; i++)
            Assert.AreEqual(expected[i], actual[i]);
    }
}