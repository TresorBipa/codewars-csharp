using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class EnumerableMagic25TakeFirstNElementsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 0, 1, 2 },
                EnumerableMagic25TakeFirstNElements.Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 3));

            Assert.AreEqual(new int[] { },
                EnumerableMagic25TakeFirstNElements.Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 0));
            Assert.AreEqual(new int[] { }, EnumerableMagic25TakeFirstNElements.Take(new int[] { }, 3));
        }


        private static readonly Random Rand = new Random();

        private static int[] Solution(int[] arr, int n)
        {
            return arr.Take(n).ToArray();
        }

        private static int[] RandomArray()
        {
            return Enumerable.Range(0, Rand.Next(15)).Select(x => Rand.Next(0, 100)).ToArray();
        }

        [Test]
        public void RandomTests1()
        {
            for (var i = 0; i < 200; i++)
            {
                var randomArray = RandomArray();
                var n = Rand.Next(0, 15);
                var expected = Solution(randomArray, n);
                var message = FailureMessage(randomArray, expected, n);
                var actual = EnumerableMagic25TakeFirstNElements.Take(randomArray, n);
                // Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        [Test]
        public void RandomTests2()
        {
            for (var i = 0; i < 200; i++)
            {
                var randomArray = RandomArray();
                var n = Rand.Next(15, 100);
                var expected = Solution(randomArray, n);
                var message = FailureMessage(randomArray, expected, n);
                var actual = EnumerableMagic25TakeFirstNElements.Take(randomArray, n);
                // Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(int[] arr, int[] value, int n)
        {
            return $"Should return [{string.Join(", ", value)}] with [{string.Join(", ", arr)}] and take {n}";
        }
    }
}


