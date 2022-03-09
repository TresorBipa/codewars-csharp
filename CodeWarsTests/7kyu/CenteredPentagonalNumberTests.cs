using CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWarsTests._7kyu
{
    [TestFixture]
    public class CenteredPentagonalNumberTests
    {
        [Test]
        public void ShouldReturnMinusOne()
        {
            Assert.AreEqual(-1, CenteredPentagonalNumber.Pentagonal(0));
            Assert.AreEqual(-1, CenteredPentagonalNumber.Pentagonal(-1));
            Assert.AreEqual(-1, CenteredPentagonalNumber.Pentagonal(-21));
        }

        [Test]
        public void ShouldReturnExpectedVal()
        {
            Assert.AreEqual(1, CenteredPentagonalNumber.Pentagonal(1));
            Assert.AreEqual(6, CenteredPentagonalNumber.Pentagonal(2));
            Assert.AreEqual(141, CenteredPentagonalNumber.Pentagonal(8));
            Assert.AreEqual(226, CenteredPentagonalNumber.Pentagonal(10));
            Assert.AreEqual(24751, CenteredPentagonalNumber.Pentagonal(100));
            Assert.AreEqual(15087592276, CenteredPentagonalNumber.Pentagonal(77686));
        }
    }
}