using System;
using System.Drawing;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GeometryBasicsDistanceBetweenCirclesIn2DTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(32,
                Math.Round(
                    GeometryBasicsDistanceBetweenCirclesIn2D.DistanceBetweenCircles(
                        new GeometryBasicsDistanceBetweenCirclesIn2D.Circle(new Point(10, 60), 11),
                        new GeometryBasicsDistanceBetweenCirclesIn2D.Circle(new Point(40, 20), 7)),
                    6));
            Assert.AreEqual(0,
                Math.Round(
                    GeometryBasicsDistanceBetweenCirclesIn2D.DistanceBetweenCircles(
                        new GeometryBasicsDistanceBetweenCirclesIn2D.Circle(new Point(10, 60), 40),
                        new GeometryBasicsDistanceBetweenCirclesIn2D.Circle(new Point(40, 20), 40)),
                    6));
            Assert.AreEqual(0,
                Math.Round(
                    GeometryBasicsDistanceBetweenCirclesIn2D.DistanceBetweenCircles(
                        new GeometryBasicsDistanceBetweenCirclesIn2D.Circle(new Point(100, 100), 50),
                        new GeometryBasicsDistanceBetweenCirclesIn2D.Circle(new Point(102, 110), 10)), 6));
        }


        [Test]
        public void RandomTests()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                GeometryBasicsDistanceBetweenCirclesIn2D.Circle a =
                    new GeometryBasicsDistanceBetweenCirclesIn2D.Circle(
                        new Point(rand.Next(-50, 50), rand.Next(-50, 50)), rand.Next(1, 50));
                GeometryBasicsDistanceBetweenCirclesIn2D.Circle b =
                    new GeometryBasicsDistanceBetweenCirclesIn2D.Circle(
                        new Point(rand.Next(-50, 50), rand.Next(-50, 50)), rand.Next(1, 50));
                Assert.AreEqual(Math.Round(Solve.GetResult(a, b), 6),
                    Math.Round(GeometryBasicsDistanceBetweenCirclesIn2D.DistanceBetweenCircles(a, b), 6));
            }
        }

        public static class Solve
        {
            public static double GetResult(GeometryBasicsDistanceBetweenCirclesIn2D.Circle a,
                GeometryBasicsDistanceBetweenCirclesIn2D.Circle b)
            {
                var distanceDiff =
                    Math.Sqrt(Math.Pow(a.Center.X - b.Center.X, 2) + Math.Pow(a.Center.Y - b.Center.Y, 2)) - a.Radius -
                    b.Radius;
                return distanceDiff > 0 ? distanceDiff : 0;
            }
        }
    }
}