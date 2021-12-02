using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun11SwapAdjacentBitsTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun11SwapAdjacentBits();

            Assert.AreEqual(14, kata.SwapAdjacentBits(13), "");

            Assert.AreEqual(133, kata.SwapAdjacentBits(74), "");

            Assert.AreEqual(1073741823, kata.SwapAdjacentBits(1073741823), "");

            Assert.AreEqual(0, kata.SwapAdjacentBits(0), "");

            Assert.AreEqual(2, kata.SwapAdjacentBits(1), "");

            Assert.AreEqual(166680, kata.SwapAdjacentBits(83748), "");
        }
    }
}