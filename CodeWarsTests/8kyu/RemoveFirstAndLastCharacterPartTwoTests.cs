using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class RemoveFirstAndLastCharacterPartTwoTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(null, RemoveFirstAndLastCharacterPartTwo.Array(""));
            Assert.AreEqual(null, RemoveFirstAndLastCharacterPartTwo.Array("1"));
            Assert.AreEqual(null, RemoveFirstAndLastCharacterPartTwo.Array("1, 3"));
            Assert.AreEqual("2", RemoveFirstAndLastCharacterPartTwo.Array("1,2,3"));
            Assert.AreEqual("2 3", RemoveFirstAndLastCharacterPartTwo.Array("1,2,3,4"));
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 300; i++)
            {
                var str = RandomString();
                var expected = Solution(str);
                var message = FailureMessage(str, expected);
                var actual = RemoveFirstAndLastCharacterPartTwo.Array(str);
                // Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string Solution(string s)
        {
            var arr = s.Split(",");
            return arr.Length > 2 ? string.Join(" ", arr[1..^1]) : null;
        }

        private static readonly Random Rand = new Random();
        private const string Chars = "abcdef123456";

        private static string RandomString()
        {
            return string.Join(",", Enumerable.Range(0, Rand.Next(10))
                .Select(x =>
                    string.Concat(Enumerable.Range(0, Rand.Next(1, 4)).Select(i => Chars[Rand.Next(Chars.Length)]))));
        }

        private static string FailureMessage(string str, string value)
        {
            return $"Should return {value ?? "null"} with \"{str}\"";
        }
    }
}