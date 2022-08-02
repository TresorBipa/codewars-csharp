using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExclamationMarksSeries18Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(1000, ExclamationMarksSeries18.Slot("!!!!!"));
            Assert.AreEqual(1000, ExclamationMarksSeries18.Slot("?????"));
            Assert.AreEqual(800, ExclamationMarksSeries18.Slot("!!!!?"));
            Assert.AreEqual(800, ExclamationMarksSeries18.Slot("????!"));
            Assert.AreEqual(500, ExclamationMarksSeries18.Slot("!!!??"));
            Assert.AreEqual(500, ExclamationMarksSeries18.Slot("???!!"));
            Assert.AreEqual(300, ExclamationMarksSeries18.Slot("!!!?!"));
            Assert.AreEqual(300, ExclamationMarksSeries18.Slot("???!?"));
            Assert.AreEqual(200, ExclamationMarksSeries18.Slot("!!?!!"));
            Assert.AreEqual(200, ExclamationMarksSeries18.Slot("??!??"));
            Assert.AreEqual(100, ExclamationMarksSeries18.Slot("!!?!?"));
            Assert.AreEqual(100, ExclamationMarksSeries18.Slot("??!?!"));
            Assert.AreEqual(0, ExclamationMarksSeries18.Slot("!?!?!"));
            Assert.AreEqual(0, ExclamationMarksSeries18.Slot("?!?!?"));
        }

        private static int Solution(string s)
        {
            // var m = Regex.Matches(s, @"!+|\?+").Select(x => x.Value).OrderBy(x => -x.Length).ToArray();
            var m = Regex.Matches(s, @"!+|\?+").OrderBy(x => -x.Length).ToArray();

            return m.Length switch
            {
                1 => 1000,
                2 => m[0].Length == 4 ? 800 : 500,
                3 => m[0].Length == 3 ? 300 : 200,
                4 => 100,
                5 => 0,
                _ => 0
            };
        }

        private static readonly Random Rand = new Random();

        private static string RandomStr()
        {
            return string.Concat(Enumerable.Range(0, 5).Select(x => new[] { "!", "?" }[Rand.Next(0, 2)]).ToArray());
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 300; i++)
            {
                var str = RandomStr();
                var expected = Solution(str);
                var message = FailureMessage(str, expected);
                var actual = ExclamationMarksSeries18.Slot(str);
                Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(string str, int value)
        {
            return $"Should return {value} with \"{str}\"";
        }
    }
}