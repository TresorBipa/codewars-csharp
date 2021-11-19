using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class SquashBugsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(0, SquashBugs.FindLongest(""));
            Assert.AreEqual(4, SquashBugs.FindLongest("Bugs"));
            Assert.AreEqual(6, SquashBugs.FindLongest("  Spaces   "));
            Assert.AreEqual(3, SquashBugs.FindLongest(" A  b   c xyz"));
            Assert.AreEqual(7, SquashBugs.FindLongest("Sausage chops"));
            Assert.AreEqual(7, SquashBugs.FindLongest("Lets all go on holiday"));
            Assert.AreEqual(10, SquashBugs.FindLongest("Take me to tinseltown with you"));
            Assert.AreEqual(6, SquashBugs.FindLongest("Wind your body and wiggle your belly"));
            Assert.AreEqual(7, SquashBugs.FindLongest("The quick white fox jumped around the massive dog"));
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 300; i++)
            {
                var str = RandomString();
                var expected = Solution(str);
                var message = FailureMessage(str, expected);
                var actual = SquashBugs.FindLongest(str);
                Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static int Solution(string str)
        {
            var spl = str.Split(" ");
            var longest = 0;

            for (var i = 0; i < spl.Length; i++)
            {
                if (spl[i].Length > longest)
                {
                    longest = spl[i].Length;
                }
            }

            return longest;
        }

        private static readonly Random Rand = new Random();

        private static readonly string[] Names =
        {
            "Arsene", "Lupin", "III", "Daisuke", "Jigen", "Goemon", "Ishikawa", "Fujiko", "Mine", "Rebecca",
            "Rossellini", "Koichi", "Zenigata", "Justin", "Nix", "Person", "Leonardo", "Da", "Vinci", "Vasya"
        };

        private static string RandomString()
        {
            return string.Join(" ",
                Enumerable.Range(0, Rand.Next(Names.Length + 1))
                    .Select(x => Names[Rand.Next(Rand.Next(Names.Length + 1))]));
        }

        private static string FailureMessage(string str, int value)
        {
            return $"Should return {value} with \"{str}\"";
        }
    }
}