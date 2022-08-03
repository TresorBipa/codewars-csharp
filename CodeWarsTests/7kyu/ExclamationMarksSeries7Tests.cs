using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExclamationMarksSeries7Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("", ExclamationMarksSeries7.Remove("Hi!"));
            Assert.AreEqual("", ExclamationMarksSeries7.Remove("!Hi"));
            Assert.AreEqual("", ExclamationMarksSeries7.Remove("Hi! Hi! Hi!"));
            Assert.AreEqual("", ExclamationMarksSeries7.Remove("Hi! !Hi Hi!"));
            Assert.AreEqual("", ExclamationMarksSeries7.Remove("Hi! Hi!"));
            Assert.AreEqual("!Hi!", ExclamationMarksSeries7.Remove("!Hi!"));
            Assert.AreEqual("Hi!!!", ExclamationMarksSeries7.Remove("Hi!!!"));
            Assert.AreEqual("Hi", ExclamationMarksSeries7.Remove("Hi Hi! Hi!"));
            Assert.AreEqual("Hi hi hI", ExclamationMarksSeries7.Remove("Hi hi hI"));
            Assert.AreEqual("Hi!!", ExclamationMarksSeries7.Remove("Hi! Hi!! Hi!"));
            Assert.AreEqual("!Hi!", ExclamationMarksSeries7.Remove("Hi! !Hi! Hi!"));
            Assert.AreEqual("!Hi! !Hi!", ExclamationMarksSeries7.Remove("!Hi! ! !Hi!"));
            Assert.AreEqual("!!!Hi !!hi!!!", ExclamationMarksSeries7.Remove("!!!Hi !!hi!!! !hi"));
        }

        private static string Solution(string s)
        {
            return string.Join(" ", s.Split().Where(x => x.Split("!").Length != 2));
        }

        private static readonly Random Rand = new Random();

        private static string RandomStr()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            List<string> list = new List<string>();
            var n = Rand.Next(1, 10);
            for (var i = 0; i < n; i++)
            {
                var str = string.Concat(Enumerable.Repeat(chars, Rand.Next(1, chars.Length))
                    .Select(s => s[Rand.Next(s.Length)])
                    .Take(Rand.Next(3, 6)));

                var v = Rand.Next(0, 5);
                str = v switch
                {
                    0 => new string('!', Rand.Next(0, 4)) + str + new string('!', Rand.Next(0, 4)),
                    1 => str + new string('!', Rand.Next(0, 3)),
                    2 => new string('!', Rand.Next(0, 3)) + str,
                    3 => (Rand.Next(0, 4) == 0 ? "!" : "") + str + (Rand.Next(0, 4) == 0 ? "!" : ""),
                    _ => str
                };

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
                var actual = ExclamationMarksSeries7.Remove(str);
                // Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(string str, string value)
        {
            return $"Should return \"{value}\" with \"{str}\"";
        }
    }
}