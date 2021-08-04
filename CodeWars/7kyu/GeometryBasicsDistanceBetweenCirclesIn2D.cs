/*
https://www.codewars.com/kata/58e3031ce265671f6a000542/csharp

7 kyu
Geometry Basics: Distance between circles in 2D

This series of katas will introduce you to basics of doing geometry with computers.
Point objects have x, y attributes. Circle objects have center which is a Point, and radius which is a number.
Write a function calculating distance between Circle a and Circle b.
If they're overlapping or one is completely within the other, just return zero.
Tests round answers to 6 decimal places, so you don't need to round them yourselves.
*/

using System.Drawing;
using System;

namespace CodeWars
{
    public class GeometryBasicsDistanceBetweenCirclesIn2D
    {
        public class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }

            public Circle(Point cen, int rad)
            {
                Center = cen;
                Radius = rad;
            }
        }

        public static double DistanceBetweenCircles(Circle a, Circle b)
        {
            // var dx = a.Center.X - b.Center.X;
            // var dy = a.Center.Y - b.Center.Y;
            // var dz = Math.Sqrt(dx * dx + dy * dy);
            // return Math.Max(0.0, dz - a.Radius - b.Radius);


            return Math.Max(0, Math.Sqrt(Math.Pow(a.Center.X - b.Center.X, 2) + Math.Pow(a.Center.Y - b.Center.Y, 2)) -
                               a.Radius - b.Radius);
        }
    }
}