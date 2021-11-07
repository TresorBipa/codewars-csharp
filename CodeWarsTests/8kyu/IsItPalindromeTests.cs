using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataIsItPalindromeTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, KataIsItPalindrome.IsPalindrome(""));
            Assert.AreEqual(true, KataIsItPalindrome.IsPalindrome("a"));
            Assert.AreEqual(true, KataIsItPalindrome.IsPalindrome("aba"));
            Assert.AreEqual(true, KataIsItPalindrome.IsPalindrome("Bob"));
            Assert.AreEqual(true, KataIsItPalindrome.IsPalindrome("oWo"));
            Assert.AreEqual(false, KataIsItPalindrome.IsPalindrome("toM"));
            Assert.AreEqual(true, KataIsItPalindrome.IsPalindrome("Abba"));
            Assert.AreEqual(false, KataIsItPalindrome.IsPalindrome("kata"));
            Assert.AreEqual(true, KataIsItPalindrome.IsPalindrome("Madam"));
            Assert.AreEqual(false, KataIsItPalindrome.IsPalindrome("hello"));
            Assert.AreEqual(false, KataIsItPalindrome.IsPalindrome("not equal"));
            Assert.AreEqual(true, KataIsItPalindrome.IsPalindrome("xxmZiffiZmxx"));
            Assert.AreEqual(true, KataIsItPalindrome.IsPalindrome("AABBCCDDddccbbaa"));
            Assert.AreEqual(false, KataIsItPalindrome.IsPalindrome("asdnaisdoaufnsdfsdfsada"));
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 300; i++)
            {
                var str = RandomString();
                var expected = Solution(str);
                var message = FailureMessage(str, expected);
                var actual = KataIsItPalindrome.IsPalindrome(str);
                Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static bool Solution(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return String.Join("", charArray).ToLower() == s.ToLower();
        }

        private static readonly Random Rand = new Random();
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private static string RandomString()
        {
            var result = string.Concat(Enumerable.Range(0, Rand.Next(15))
                .Select(x => Chars[Rand.Next(Chars.Length)]));

            if (Rand.Next(100) % 2 == 0)
            {
                result += string.Concat(result.Reverse());
            }

            return result;
        }

        private static string FailureMessage(string str, bool value)
        {
            return $"Should return {value} with {str}";
        }
    }
}