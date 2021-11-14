using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class CodeGolfStringToASCIICharacterTests
    {
        private CodeGolfStringToASCIICharacter kata = new CodeGolfStringToASCIICharacter();

        [Test]
        public void SampleTest()
        {
            Assert.AreEqual('B', kata.Solution("abc"));
            Assert.AreEqual('H', kata.Solution("asd"));

            Assert.AreEqual('L',
                kata.Solution(
                    "iamareallyreallylongstringthatiscompletelyworthlessandisheretostophardcoders"));
        }

        private static char Solution(string s)
        {
            return (char)(s.ToUpper().Sum(x => x) / s.Length);
        }

        private static readonly Random Rand = new Random();

        private static string RandomStr()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return string.Concat(Enumerable.Repeat(chars, Rand.Next(1, chars.Length))
                .Select(s => s[Rand.Next(s.Length)]).OrderBy(x => Rand.Next()));
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 100; i++)
            {
                var str = RandomStr();
                var expected = Solution(str);
                var message = FailureMessage(str, expected);
                var actual = kata.Solution(str);
                Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static string FailureMessage(string str, char value)
        {
            return $"Should return '{value}' with \"{str}\"";
        }

        // [Test]
        // public void CodeSizeCheckTest()
        // {
        //     // var code = System.IO.File.ReadAllText(@"/workspace/solution.txt");
        //     var code = System.IO.File.ReadAllText(
        //         @"D:\csharp\codewars-csharp\CodeWars\CodeGolfStringToASCIICharacter.cs");
        //     Console.WriteLine(code.Length);
        //     Assert.AreEqual(true, code.Length < 860, $"Your code should be less than 60 characters ({code.Length})");
        // }
    }
}