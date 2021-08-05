using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GreatestCommonDivisorBitcountTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(6, GreatestCommonDivisorBitcount.GcdBinary(666666, 333111));
            Assert.AreEqual(1, GreatestCommonDivisorBitcount.GcdBinary(545034, 5));
            Assert.AreEqual(0, GreatestCommonDivisorBitcount.GcdBinary(0, 0));
            Assert.AreEqual(14, GreatestCommonDivisorBitcount.GcdBinary(0, 76899299));
            Assert.AreEqual(1, GreatestCommonDivisorBitcount.GcdBinary(-124, -16));
        }
    }
}