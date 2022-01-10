using System.Numerics;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NthOrderSummationTests
    {
        [TestFixture]
        public class SampleTests
        {
            private static void Act(BigInteger m, BigInteger n, BigInteger expected)
            {
                var msg = $"Invalid answer for: m = {m}, n = {n}";
                var actual = NthOrderSummation.S(m, n);
                Assert.AreEqual(expected, actual, msg);
            }

            [TestCase(0, 1, 1)]
            [TestCase(1, 1, 1)]
            [TestCase(0, 53, 1)]
            [TestCase(1, 49, 49)]
            [TestCase(1, 101, 101)]
            [TestCase(2, 5, 15)]
            [TestCase(2, 99, 4950)]
            [TestCase(3, 7, 84)]
            [TestCase(3, 32, 5984)]
            [TestCase(4, 8, 330)]
            [TestCase(5, 17, 20349)]
            [TestCase(10, 4, 286)]
            public void SmallTests(int m, int n, int expected)
                => Act(m, n, expected);
        }
    }
}