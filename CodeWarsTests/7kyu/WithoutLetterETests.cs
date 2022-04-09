using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class WithoutLetterETests
    {
        private static readonly Random Rand = new Random();

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("1", WithoutLetterE.FindE("e"));
            Assert.AreEqual("2", WithoutLetterE.FindE("ee"));
            Assert.AreEqual("3", WithoutLetterE.FindE("Eee"));
            Assert.AreEqual("4", WithoutLetterE.FindE("eeeE"));
            Assert.AreEqual("7", WithoutLetterE.FindE("EeeEeeE"));
            Assert.AreEqual("There is no \"e\".", WithoutLetterE.FindE("actual"));
            Assert.AreEqual("1", WithoutLetterE.FindE("Codewars"));
            Assert.AreEqual("", WithoutLetterE.FindE(""));
            Assert.AreEqual(null, WithoutLetterE.FindE(null));
        }

        [Test]
        public void GadsbyTest()
        {
            string Gadsby1 =
                "If youth, throughout all history, had had a champion to stand up for it; to show a doubting\n"
                + "world that a child can think; and, possibly, do it practically; you wouldn’t constantly run\n"
                + "across folks today who claim that “a child don’t know anything.” A child’s brain starts\n"
                + "functioning at birth; and has, amongst its many infant convolutions, thousands of dormant\n"
                + "atoms, into which God has put a mystic possibility for noticing an adult’s act, and figuring\n"
                + "out its purport.";

            Assert.AreEqual("There is no \"e\".", WithoutLetterE.FindE(Gadsby1));

            string Gadsby2 =
                "I THINK THAT now you should know this charming Gadsby family; so I will bring forth\n"
                + "Lady Gadsby, about whom I told you at Gadsby’s inauguration as Mayor; a loyal church\n"
                + "woman with a vocal ability for choir work; and, with good capability on piano or organ,\n"
                + "no woman could “fill in” in so many ways; and no woman was so willing, and quick to do\n"
                + "so. Gadsby had two sons; bright lads and popular with all. Julius was of a studious turn of\n"
                + "mind, always poring through books of information; caring not what kind of information it\n"
                + "was, so long as it was information, and not fiction.";

            Assert.AreEqual("There is no \"e\".", WithoutLetterE.FindE(Gadsby2));
        }

        private static string Solution(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            var count = s.ToLower().Count(x => x == 'e');
            return count == 0 ? "There is no \"e\"." : count.ToString();
        }

        private static string RandomStr()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890 ";
            return string.Concat(Enumerable.Repeat(chars, Rand.Next(0, chars.Length))
                .Select(s => s[Rand.Next(s.Length)]));
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 200; i++)
            {
                var e = RandomStr();
                var expected = Solution(e);
                var message = FailureMessage(e, expected);

                var actual = WithoutLetterE.FindE(e);

                Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(string s, string value)
        {
            return $"Should return \"{value}\" with \"{s}\"";
        }
    }
}


