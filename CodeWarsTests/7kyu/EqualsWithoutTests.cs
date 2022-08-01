using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class EqualsWithoutTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.IsTrue(EqualsWithout.Equals(1234, 1234), "for a: 1234 and b: 1234");
            Assert.IsTrue(EqualsWithout.Equals(12, 12), "for a: 12 and b: 12");
            Assert.IsTrue(EqualsWithout.Equals(24, 24), "for a: 24 and b: 24");
            Assert.IsTrue(EqualsWithout.Equals(1, 1), "for a: 1 and b: 1");
            Assert.IsTrue(EqualsWithout.Equals(9, 9), "for a: 9 and b: 9");

            Assert.IsFalse(EqualsWithout.Equals(1234, 1233), "for a: 1234 and b: 1233");
            Assert.IsFalse(EqualsWithout.Equals(12, 14), "for a: 12 and b: 14");
            Assert.IsFalse(EqualsWithout.Equals(24, 2), "for a: 24 and b: 2");
            Assert.IsFalse(EqualsWithout.Equals(1, 2), "for a: 1 and b: 2");
            Assert.IsFalse(EqualsWithout.Equals(9, 59), "for a: 9 and b: 59");

            // Assert.AreEqual(true, EqualsWithout.Equals(1234, 1234));
            // Assert.AreEqual(true, EqualsWithout.Equals(12, 12));
            // Assert.AreEqual(true, EqualsWithout.Equals(24, 24));
            // Assert.AreEqual(true, EqualsWithout.Equals(1, 1));
            // Assert.AreEqual(true, EqualsWithout.Equals(9, 9));
            //
            // Assert.AreEqual(false, EqualsWithout.Equals(1234, 1233));
            // Assert.AreEqual(false, EqualsWithout.Equals(12, 14));
            // Assert.AreEqual(false, EqualsWithout.Equals(24, 2));
            // Assert.AreEqual(false, EqualsWithout.Equals(1, 2));
            // Assert.AreEqual(false, EqualsWithout.Equals(9, 59));
        }

        [Test]
        public void RandomTest()
        {
            for (var i = 0; i < 300; i++)
            {
                var a = Rand.Next(10000);
                var b = Rand.Next(10000);

                if (Rand.Next(100) % 2 == 0)
                {
                    b = a;
                }

                var expected = Solution(a, b);
                var message = FailureMessage(a, b, expected);
                var actual = EqualsWithout.Equals(a, b);
                Console.WriteLine(message);
                Assert.AreEqual(expected, actual, message);
            }
        }

        private static bool Solution(int a, int b)
        {
            return a.Equals(b);
        }

        private static readonly Random Rand = new Random();

        private static string FailureMessage(int a, int b, bool value)
        {
            return $"Should return {value} with a={a} and b={b}";
        }

        // [Test]
        // public void NotUsingEqualsOperatorTest()
        // {
        //     // var code = System.IO.File.ReadAllText(@"/workspace/solution.txt");
        //     var code = System.IO.File.ReadAllText(@"D:\csharp\codewars-csharp\CodeWars\EqualsWithout.cs");
        //     Assert.AreEqual(false, code.Contains("="), "It is forbidden to use the '=' symbol in the code");
        // }
    }
}