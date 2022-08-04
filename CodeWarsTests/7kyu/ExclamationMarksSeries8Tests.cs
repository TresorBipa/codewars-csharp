using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExclamationMarksSeries8Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Hi!", ExclamationMarksSeries8.Remove("Hi!"));
            Assert.AreEqual("Hi Hi!!", ExclamationMarksSeries8.Remove("Hi! Hi!"));
            Assert.AreEqual("Hi Hi Hi!!!", ExclamationMarksSeries8.Remove("Hi! Hi! Hi!"));
            Assert.AreEqual("Hi Hi Hi!!!", ExclamationMarksSeries8.Remove("Hi! !Hi Hi!"));
            Assert.AreEqual("Hi Hi Hi!!!", ExclamationMarksSeries8.Remove("Hi! !Hi Hi!"));
            Assert.AreEqual("Hi Hi Hi!!!!", ExclamationMarksSeries8.Remove("Hi! Hi!! Hi!"));
        }

        private static string Solution(string s)
        {
            return s.Replace("!", "") + new string('!', s.Count(x => x == '!'));
        }

        private static readonly Random Rand = new Random();

        private static string RandomStr()
        {
            const string chars =
                "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_ !@#$%^&*_(),.?|{}[]-=+\\/";

            List<string> list = new List<string>();
            var n = Rand.Next(1, 10);
            for (var i = 0; i < n; i++)
            {
                var str = string.Concat(Enumerable.Repeat(chars, Rand.Next(1, chars.Length))
                    .Select(s => s[Rand.Next(s.Length)])
                    .Take(Rand.Next(3, 6)));

                if (Rand.Next(0, 1000) % 3 == 0) str += "!" + new string('!', Rand.Next(0, 3));
                if (Rand.Next(0, 1000) % 3 == 0) str = "!" + new string('!', Rand.Next(0, 3)) + str;

                list.Add(str);
            }

            return string.Join(" ", list);
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 300; i++)
            {
                var str = RandomStr();
                var expected = Solution(str);
                var message = FailureMessage(str, expected);
                var actual = ExclamationMarksSeries8.Remove(str);
                Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(string str, string value)
        {
            return $"Should return \"{value}\" with \"{str}\"";
        }
    }
}