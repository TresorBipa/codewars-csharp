using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StringLetterCountingTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("1a1b1c1d3e1f1g2h1i1j1k1l1m1n4o1p1q2r1s2t2u1v1w1x1y1z",
                StringLetterCounting.StringLetterCount("The quick brown fox jumps over the lazy dog."));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("2a1d5e1g1h4i1j2m3n3o3s6t1u2w2y",
                StringLetterCounting.StringLetterCount("The time you enjoy wasting is not wasted time."));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("", StringLetterCounting.StringLetterCount("./4592#{}()"));
        }
    }
}