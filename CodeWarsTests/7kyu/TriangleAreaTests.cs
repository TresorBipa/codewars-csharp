using System;
using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TriangleAreaTests
    {
        private static string BuildT(int n) =>
            String.Join("", Enumerable
                .Range(0, n + 1)
                .Select((_, i) => string.Concat(Enumerable.Repeat(". ", i)).Trim() + "\n"));


        private static void Act(int n, double expected)
        {
            var s = BuildT(n);
            var msg = $"Invalid answer for: \"{s}\"";
            var actual = TriangleArea.TArea(s);
            Assert.AreEqual(expected, actual, msg);
        }

        [TestCase(2, 0.5)]
        [TestCase(3, 2)]
        [TestCase(9, 32)]
        [TestCase(5, 8)]
        public void FixedTests(int n, double expected) => Act(n, expected);
    }
}