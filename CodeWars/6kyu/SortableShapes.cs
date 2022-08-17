/*
https://www.codewars.com/kata/586669a8442e3fc307000048/csharp

6 kyu
Sortable Shapes

Although shapes can be very different by nature, they can be sorted by the size of their area.

Task:
Create different shapes that can be part of a sortable list. 
The sort order is based on the size of their respective areas:
The area of a Square is the square of its side
The area of a Rectangle is width multiplied by height
The area of a Triangle is base multiplied by height divided by 2
The area of a Circle is the square of its radius multiplied by π
The area of a CustomShape is given

The default sort order of a list of shapes is ascending on area size:
var side = 1.1234D;
var radius = 1.1234D;
var base = 5D;
var height = 2D;

var shapes = new List<Shape>{ new Square(side),
                            new Circle(radius),
                            new Triangle(base, height) };
shapes.Sort();
Use the correct π constant for your circle area calculations:
System.Math.PI
*/


using System;

namespace CodeWars._6kyu;

public class SortableShapes
{
    public abstract class Shape : IComparable<Shape>
    {
        protected abstract double Area { get; }

        public int CompareTo(Shape shape)
        {
            if (shape != null && Area != shape.Area)
                return Area > shape.Area ? 1 : -1;
            return 0;
        }
    }

    public class Triangle : Shape
    {
        private double? area;
        private readonly double triangleBase;
        private readonly double height;

        public Triangle(double triangleBase, double height)
        {
            this.triangleBase = triangleBase;
            this.height = height;
        }

        protected override double Area
        {
            get
            {
                area ??= triangleBase * height / 2;
                return area.Value;
            }
        }
    }

    public class Rectangle : Shape
    {
        private double? area;
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        protected override double Area
        {
            get
            {
                area ??= width * height;
                return area.Value;
            }
        }
    }

    public class Square : Shape
    {
        private double? area;
        private readonly double side;

        public Square(double side)
        {
            this.side = side;
        }

        protected override double Area
        {
            get
            {
                area ??= side * side;
                return area.Value;
            }
        }
    }

    public class Circle : Shape
    {
        private double? area;
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        protected override double Area
        {
            get
            {
                area ??= Math.Pow(radius, 2) * Math.PI;
                return area.Value;
            }
        }
    }

    public class CustomShape : Shape
    {
        protected override double Area { get; }

        public CustomShape(double area)
        {
            Area = area;
        }
    }
}