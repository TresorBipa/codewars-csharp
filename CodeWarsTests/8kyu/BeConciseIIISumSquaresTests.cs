using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class BeConciseIIISumSquaresTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(55, BeConciseIIISumSquares.SumSquares(new[] { 1, 2, 3, 4, 5 }),
                "Should return 55 with [1, 2, 3, 4, 5]");

            Assert.AreEqual(200, BeConciseIIISumSquares.SumSquares(new[] { 7, 3, 9, 6, 5 }),
                "Should return 200 with [7, 3, 9, 6, 5]");

            Assert.AreEqual(843, BeConciseIIISumSquares.SumSquares(new[] { 11, 13, 15, 18, 2 }),
                "Should return 55 with [11, 13, 15, 18, 2]");

            Assert.AreEqual(110, BeConciseIIISumSquares.SumSquares(new[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 }),
                "Should return 110 with [-5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5]");

            Assert.AreEqual(0, BeConciseIIISumSquares.SumSquares(new int[] { }),
                "Should return 0 with []");

            Assert.AreEqual(0, BeConciseIIISumSquares.SumSquares(new int[] { 0 }),
                "Should return 0 with []");

            Assert.AreEqual(4, BeConciseIIISumSquares.SumSquares(new int[] { 2 }),
                "Should return 4 with [2]");

            Assert.AreEqual(4, BeConciseIIISumSquares.SumSquares(new int[] { -2 }),
                "Should return 4 with [-2]");
        }

        private static int Solution(int[] array)
        {
            return array.Aggregate(0, (acc, value) => acc + (int)Math.Pow(value, 2));
        }

        private static readonly Random Rand = new Random();

        private static int[] RandomArray(int count, int minNum, int maxNum)
        {
            return Enumerable.Range(0, Rand.Next(0, count)).Select(x => Rand.Next(minNum, maxNum)).ToArray();
        }

        private static string FailureMessage(int[] array, int value)
        {
            var joinArray = string.Join(", ", array);
            return $"Should return {value} with [{joinArray}]";
        }

        [Test]
        public void RandomTest1()
        {
            for (var i = 0; i < 100; i++)
            {
                var randomArray = RandomArray(Rand.Next(5, 10), Rand.Next(-100, 0), Rand.Next(1, 100));

                var expected = Solution(randomArray);
                var message = FailureMessage(randomArray, expected);
                var actual = BeConciseIIISumSquares.SumSquares(randomArray);
                Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        [Test]
        public void RandomTest2()
        {
            for (var i = 0; i < 100; i++)
            {
                var randomArray = Enumerable.Range(Rand.Next(-100, 100), Rand.Next(15)).ToArray();

                var expected = Solution(randomArray);
                var message = FailureMessage(randomArray, expected);
                var actual = BeConciseIIISumSquares.SumSquares(randomArray);
                Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }
    }
}