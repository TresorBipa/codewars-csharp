using System;
using CodeWars;
using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindTwoDoublesForGivenSumAndProductTests
    {
        [Test]
        public void TestSumAndProduct_FixedTests()
        {
            Check(2, 2, 4, 4);
            Check(3, 5, 8, 15);
            Check(1.25, 7.8, 9.05, 9.75);
            Check(-2, -2, -4, 4);
            Assert.AreEqual(null, FindTwoDoublesForGivenSumAndProduct.FindDoubles(2, 7 / 3),
                "(2, 7/3) requires 'null' as return value");
        }

        public void Check(double x1, double x2, double sum, double product)
        {
            Tuple<double, double> actual = FindTwoDoublesForGivenSumAndProduct.FindDoubles(sum, product);
            if (actual == null)
            {
                Assert.Fail("Actual cannot be null for ({0}, {1})", sum, product);
            }

            actual = new Tuple<double, double>(Math.Round(actual.Item1, 5), Math.Round(actual.Item2, 5));
            x1 = Math.Round(x1, 5);
            x2 = Math.Round(x2, 5);
            // Rounding to 5 decimals, to avoid errors for very minor rounding errors,
            // caused by the fact that all numbers stored as a double have a 
            // limited amount of decimals, so rounding might happen, which can cause a
            // very small difference in expected and actual solutions, but small enough
            // so rounding to 5 digits should equalize them.
            if (!((actual.Item1 == x1 && actual.Item2 == x2) ||
                  (actual.Item1 == x2 && actual.Item2 == x1)))
            {
                Assert.Fail("Invalid output for input ({0}, {1}); expected was: ({2}, {3}), but actual was: ({4}, {5})",
                    sum, product, x1, x2, actual.Item1, actual.Item2);
            }
        }
    }
}