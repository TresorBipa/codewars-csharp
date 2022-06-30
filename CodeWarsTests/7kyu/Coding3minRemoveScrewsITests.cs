using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class Coding3MinRemoveScrewsITests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(0, Coding3MinRemoveScrewsI.Sc(""));
            Assert.AreEqual(1, Coding3MinRemoveScrewsI.Sc("+"));
            Assert.AreEqual(1, Coding3MinRemoveScrewsI.Sc("-"));
            Assert.AreEqual(8, Coding3MinRemoveScrewsI.Sc("+-"));
            Assert.AreEqual(8, Coding3MinRemoveScrewsI.Sc("-+"));
            Assert.AreEqual(16, Coding3MinRemoveScrewsI.Sc("---+++"));
            Assert.AreEqual(36, Coding3MinRemoveScrewsI.Sc("-+-+-+"));
            Assert.AreEqual(49, Coding3MinRemoveScrewsI.Sc("-+-+-----------"));
            Assert.AreEqual(54, Coding3MinRemoveScrewsI.Sc("-+-+-++++++++++"));
        }

        private static int Solution(string screws)
        {
            var totalTime = 0;
            for (var i = 0; i < screws.Length; i++)
                totalTime += i == 0 ? 1 : screws[i] == screws[i - 1] ? 2 : 7;

            return totalTime;
        }

        private static readonly Random Rand = new Random();

        private static string RandomStr()
        {
            const string chars = "+-";
            return string.Concat(Enumerable.Range(0, Rand.Next(6, 57)).Select(x => chars[Rand.Next(chars.Length)]));
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 300; i++)
            {
                var str = RandomStr();
                var expected = Solution(str);
                var message = FailureMessage(str, expected);
                var actual = Coding3MinRemoveScrewsI.Sc(str);
                // Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(string str, int value)
        {
            return $"Should return {value} with \"{str}\"";
        }
    }
}