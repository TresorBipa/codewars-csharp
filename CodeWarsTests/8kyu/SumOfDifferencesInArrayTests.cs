using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOfDifferencesInArrayTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { }));
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { 0 }));
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { 1 }));
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { -1 }));
            Assert.AreEqual(34, SumOfDifferencesInArray.SumOfDifferences(new int[] { -17, 17 }));
            Assert.AreEqual(9, SumOfDifferencesInArray.SumOfDifferences(new int[] { 2, 1, 10 }));
            Assert.AreEqual(2, SumOfDifferencesInArray.SumOfDifferences(new int[] { -3, -2, -1 }));
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { 1, 1, 1, 1, 1 }));
            Assert.AreEqual(0, SumOfDifferencesInArray.SumOfDifferences(new int[] { 0, 0, 0, 0, 0 }));
            Assert.AreEqual(4, SumOfDifferencesInArray.SumOfDifferences(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(29, SumOfDifferencesInArray.SumOfDifferences(new int[] { 0, 29, 24, 17 }));
            Assert.AreEqual(50, SumOfDifferencesInArray.SumOfDifferences(new int[] { 25, 24, -25, 2 }));
            Assert.AreEqual(22, SumOfDifferencesInArray.SumOfDifferences(new int[] { -26, -4, -8, -8 }));
        }

        private static int Solution(int[] arr)
        {
            return arr.Length > 1 ? arr.Max() - arr.Min() : 0;
        }

        private static readonly Random Rand = new Random();

        private static int[] RandomArray()
        {
            return Enumerable.Range(0, Rand.Next(30)).Select(x => Rand.Next(-30, 30)).ToArray();
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 300; i++)
            {
                var arr = RandomArray();
                var expected = Solution(arr);
                var message = FailureMessage(arr, expected);
                var actual = SumOfDifferencesInArray.SumOfDifferences(arr);
                // Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(int[] arr, int value)
        {
            return $"Should return {value} with [{string.Join(", ", arr)}]";
        }
    }
}