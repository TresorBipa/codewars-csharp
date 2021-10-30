using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class WhichStringIsWorthMoreTests
    {
        private static readonly Random Rand = new Random();

        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("KkLlMmNnOoPp4567",
                WhichStringIsWorthMore.HighestValue("AaBbCcXxYyZz0189", "KkLlMmNnOoPp4567"));
            Assert.AreEqual("ABcd", WhichStringIsWorthMore.HighestValue("ABcd", "0123"));
            Assert.AreEqual("{}[]@~'#:;", WhichStringIsWorthMore.HighestValue("!\"?$%^&*()", "{}[]@~'#:;"));
            Assert.AreEqual("ABCD", WhichStringIsWorthMore.HighestValue("ABCD", "DCBA"));
            Assert.AreEqual("Abc", WhichStringIsWorthMore.HighestValue("", "Abc"));
        }

        private static string Solution(string a, string b)
        {
            int Sum(string s) => s.Sum(c => c);
            return Sum(a) >= Sum(b) ? a : b;
        }

        private static string RandomStr()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()-_=+[]{}|;':,.<>?`~ ";
            return string.Concat(Enumerable.Repeat(chars, Rand.Next(0, chars.Length))
                .Select(s => s[Rand.Next(s.Length)]));
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 100; i++)
            {
                string a = RandomStr();
                string b = RandomStr();
                string actual = WhichStringIsWorthMore.HighestValue(a, b);
                string expected = Solution(a, b);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}