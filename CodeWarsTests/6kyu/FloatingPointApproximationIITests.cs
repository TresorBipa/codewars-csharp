using System;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FloatingPointApproximationIITests
    {
        private static void testing(List<double> actual, List<double> expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Fixed Tests f: x => x");
            testing(FloatingPointApproximationII.Interp(x => x, 0, 9.0, 4),
                new List<double>() {0, 2.25, 4.5, 6.75});

            testing(FloatingPointApproximationII.Interp(x => x, 0, 15.0, 9),
                new List<double>() {0, 1.66, 3.33, 5.0, 6.66, 8.33, 10.0, 11.66, 13.33});
        }

        [Test]
        public static void test2()
        {
            Console.WriteLine("Fixed Tests f: x => sin(x)");
            testing(FloatingPointApproximationII.Interp(x => Math.Sin(x), 0, 18.0, 12),
                new List<double>() {0.0, 0.99, 0.14, -0.98, -0.28, 0.93, 0.41, -0.88, -0.54, 0.8, 0.65, -0.72});

            testing(FloatingPointApproximationII.Interp(x => Math.Sin(x), 0, 21.0, 10),
                new List<double>() {0.0, 0.86, -0.88, 0.01, 0.85, -0.88, 0.03, 0.84, -0.89, 0.05});
        }

        [Test]
        public static void test3()
        {
            Console.WriteLine("Fixed Tests f: x => cos(x)");
            testing(FloatingPointApproximationII.Interp(x => Math.Cos(x), 0, 21.0, 7),
                new List<double>() {1.0, -0.99, 0.96, -0.92, 0.84, -0.76, 0.66});

            testing(FloatingPointApproximationII.Interp(x => Math.Cos(x), 0, 15.0, 12),
                new List<double>() {1.0, 0.31, -0.81, -0.83, 0.28, 0.99, 0.34, -0.79, -0.84, 0.25, 0.99, 0.37});
        }
    }
}