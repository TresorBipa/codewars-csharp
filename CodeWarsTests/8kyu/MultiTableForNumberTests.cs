using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MultiTableForNumberTests
    {
        [Test]
        public void BasicTest()
        {
            var one =
                "1 * 1 = 1\n2 * 1 = 2\n3 * 1 = 3\n4 * 1 = 4\n5 * 1 = 5\n6 * 1 = 6\n7 * 1 = 7\n8 * 1 = 8\n9 * 1 = 9\n10 * 1 = 10";
            Assert.AreEqual(one, MultiTableForNumber.MultiTable(1));

            var five =
                "1 * 5 = 5\n2 * 5 = 10\n3 * 5 = 15\n4 * 5 = 20\n5 * 5 = 25\n6 * 5 = 30\n7 * 5 = 35\n8 * 5 = 40\n9 * 5 = 45\n10 * 5 = 50";
            Assert.AreEqual(five, MultiTableForNumber.MultiTable(5));
        }

        private static string Solution(int number)
        {
            return string.Join("\n", Enumerable.Range(1, 10).Select(i => $"{i} * {number} = {i * number}"));
        }

        [Test]
        public void MultiTableTest()
        {
            for (var i = 1; i <= 10; i++)
            {
                var expected = MultiTableForNumber.MultiTable(i);
                var message = FailureMessage(i);
                var actual = Solution(i);

                Assert.AreEqual(expected, actual, message);
            }
        }

        private static readonly Random Rand = new Random();

        [Test]
        public void RandomTest()
        {
            for (var i = 1; i < 50; i++)
            {
                int n = Rand.Next(1, 11);
                var expected = MultiTableForNumber.MultiTable(n);
                var message = FailureMessage(n);
                var actual = Solution(n);
                // Console.WriteLine(expected);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(int value)
        {
            return $"Incorrect answer for {value}";
        }
    }
}