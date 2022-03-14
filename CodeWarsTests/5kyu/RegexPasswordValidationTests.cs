using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class RegexPasswordValidationTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, RegexPasswordValidation.Validate("fjd3IR9"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("ghdfj32"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("DSJKHD23"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("dsF43"));
            Assert.AreEqual(true, RegexPasswordValidation.Validate("4fdg5Fj3"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("DHSJdhjsU"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("fjd3IR9.;"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("fjd3  IR9"));
            Assert.AreEqual(true, RegexPasswordValidation.Validate("djI38D55"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("a2.d412"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("JHD5FJ53"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("!fdjn345"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("jfkdfj3j"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("123"));
            Assert.AreEqual(false, RegexPasswordValidation.Validate("abc"));
            Assert.AreEqual(true, RegexPasswordValidation.Validate("123abcABC"));
            Assert.AreEqual(true, RegexPasswordValidation.Validate("ABC123abc"));
            Assert.AreEqual(true, RegexPasswordValidation.Validate("Password123"));
        }

        private static readonly Random Rand = new Random();

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 300; i++)
            {
                var str = RandomStr();
                var expected = Solution(str);
                var message = FailureMessage(str, expected);
                var actual = RegexPasswordValidation.Validate(str);
                Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static bool Solution(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[a-zA-Z0-9]{6,}$");
        }

        private static string RandomStr()
        {
            var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            if (Rand.Next(0, 1000) % 2 == 0) chars += " !_+-?/\\";

            return string.Concat(Enumerable.Range(0, Rand.Next(0, chars.Length + 1))
                .Select(x => chars[Rand.Next(chars.Length)]));
        }

        private static string FailureMessage(string str, bool value)
        {
            return $"Should return {value} with \"{str}\"";
        }
    }
}