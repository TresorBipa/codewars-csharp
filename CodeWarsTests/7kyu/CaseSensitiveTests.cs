using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataCaseSensitiveTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new Tuple<bool, char[]>(true, new char[] { }), KataCaseSensitive.CaseSensitive("asd"),
                "Should return [True, []] with \"asd\"");

            Assert.AreEqual(new Tuple<bool, char[]>(false, new char[] { 'S' }),
                KataCaseSensitive.CaseSensitive("cellS"),
                "Should return [False, ['S']] with \"cellS\"");

            Assert.AreEqual(new Tuple<bool, char[]>(true, new char[] { }), KataCaseSensitive.CaseSensitive("asd"),
                "Should return [True, []] with \"z\"");

            Assert.AreEqual(new Tuple<bool, char[]>(true, new char[] { }), KataCaseSensitive.CaseSensitive(""),
                "Should return [True, []] with \"\"");

            Assert.AreEqual(new Tuple<bool, char[]>(true, new char[] { }), KataCaseSensitive.CaseSensitive("codewars"),
                "Should return [True, []] with \"\"");

            Assert.AreEqual(new Tuple<bool, char[]>(false, new char[] { 'W', 'R' }),
                KataCaseSensitive.CaseSensitive("codeWaRs"),
                "Should return [False, ['W', 'R']] with \"codeWaRs\"");
        }

        private static Tuple<bool, char[]> Solution(string s)
        {
            char[] upperChars = s.Where(char.IsUpper).ToArray();
            bool isUpperChars = !upperChars.Any();
            return new Tuple<bool, char[]>(isUpperChars, upperChars);
        }

        private static readonly Random Rand = new Random();

        private static string RandomStr()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return string.Concat(Enumerable.Repeat(chars, Rand.Next(0, chars.Length))
                .Select(s => s[Rand.Next(s.Length)]));
        }

        private static string FailureMessage(string s, Tuple<bool, char[]> value)
        {
            var (isUpperChars, upperChars) = value;
            var arrayStr = string.Join(", ", upperChars.Select(x => $"'{x}'"));
            return $"Should return [{isUpperChars}, [{arrayStr}]] with \"{s}\"";
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 100; i++)
            {
                string randomStr = RandomStr();
                Tuple<bool, char[]> expected = Solution(randomStr);
                string message = FailureMessage(randomStr, expected);
                Tuple<bool, char[]> actual = KataCaseSensitive.CaseSensitive(randomStr);

                Assert.AreEqual(expected, actual, message);
            }
        }
    }
}


