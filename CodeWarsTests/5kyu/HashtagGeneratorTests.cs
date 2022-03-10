using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class HashtagGeneratorTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("#A", HashtagGenerator.GenerateHashtag("a"));
            Assert.AreEqual("#ABC", HashtagGenerator.GenerateHashtag("a b c"));
            Assert.AreEqual("#ABC", HashtagGenerator.GenerateHashtag("   a   b   C   "));
            Assert.AreEqual("#ABC", HashtagGenerator.GenerateHashtag("   A   B   C   "));
            Assert.AreEqual("#Abc", HashtagGenerator.GenerateHashtag("ABC"));
            Assert.AreEqual("#Codewars", HashtagGenerator.GenerateHashtag("Codewars"));
            Assert.AreEqual("#Codewars", HashtagGenerator.GenerateHashtag("codeWars"));
            Assert.AreEqual("#Codewars", HashtagGenerator.GenerateHashtag("cOdEwArs   "));
            Assert.AreEqual("#Codewars", HashtagGenerator.GenerateHashtag("   CoDeWaRS"));
            Assert.AreEqual("#Codewars", HashtagGenerator.GenerateHashtag("   CodeWarS   "));
            Assert.AreEqual("#CodeWars", HashtagGenerator.GenerateHashtag("Code Wars"));
            Assert.AreEqual("#CodeWars", HashtagGenerator.GenerateHashtag("   code   wars   "));
            Assert.AreEqual("#CodeWars", HashtagGenerator.GenerateHashtag("code" + new string(' ', 200) + "wars"));
            Assert.AreEqual("#CodewarsIsNice", HashtagGenerator.GenerateHashtag("Codewars Is Nice"));
            Assert.AreEqual("#CodewarsIsNice", HashtagGenerator.GenerateHashtag("Codewars is nice"));
            Assert.AreEqual("#DoWeHaveAHashtag", HashtagGenerator.GenerateHashtag("Do We have A Hashtag"));
            Assert.AreEqual("#A" + new string('a', 138), HashtagGenerator.GenerateHashtag(new string('a', 139)));
            Assert.AreEqual(null, HashtagGenerator.GenerateHashtag(new string('a', 140)));
            Assert.AreEqual(null, HashtagGenerator.GenerateHashtag(new string(' ', 200)));
            Assert.AreEqual(null, HashtagGenerator.GenerateHashtag(""));

            Assert.AreEqual(null,
                HashtagGenerator.GenerateHashtag(
                    "Looooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooong Cat"));
        }


        private static string Solution(string s)
        {
            var result = string.Concat(("# " + s).ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => char.ToUpper(x[0]) + x[1..]));
            return result.Length < 2 || result.Length > 140 ? null : result;
        }

        private static readonly Random Rand = new Random();


        private static string RandomStr()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";

            List<string> result = new List<string>();
            var n = Rand.Next(1, 20);
            for (var i = 0; i < n; i++)
            {
                var str = string.Concat(Enumerable.Repeat(chars, Rand.Next(chars.Length))
                    .Select(s => s[Rand.Next(s.Length)]));

                result.Add(str);
            }

            return string.Join(" ", result.ToArray());
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 200; i++)
            {
                var str = RandomStr();
                var expected = Solution(str);
                var message = FailureMessage(str, expected);
                var actual = HashtagGenerator.GenerateHashtag(str);
                // Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(string str, string value)
        {
            return $"Should return {value ?? "null"} with \"{str}\"";
        }
    }
}