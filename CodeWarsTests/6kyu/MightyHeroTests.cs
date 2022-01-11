using System.Numerics;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MightyHeroTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(MightyHero.CountOfHeads(2, 1, 1), new BigInteger(2));
            Assert.AreEqual(MightyHero.CountOfHeads(5, 10, 3), new BigInteger(92));
            Assert.AreEqual(MightyHero.CountOfHeads(5, 10, 2), new BigInteger(33));
            Assert.AreEqual(MightyHero.CountOfHeads(51, 6, 31), BigInteger.Parse("50983496835888389711611599965641898"));
            Assert.AreEqual(MightyHero.CountOfHeads(30, 12, 31), BigInteger.Parse("101966993671776779423223199931283755"));
            Assert.AreEqual(MightyHero.CountOfHeads(10, 8, 3), new BigInteger(79));
            Assert.AreEqual(MightyHero.CountOfHeads(1, 1, 3), new BigInteger(7));
            Assert.AreEqual(MightyHero.CountOfHeads(100, 143, 8), new BigInteger(6611411));
        }
    }
}