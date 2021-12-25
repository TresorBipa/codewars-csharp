using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun18CandlesTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun18Candles();

            Assert.AreEqual(9, kata.Candles(5, 2));

            Assert.AreEqual(1, kata.Candles(1, 2));

            Assert.AreEqual(4, kata.Candles(3, 3));

            Assert.AreEqual(16, kata.Candles(11, 3));
        }
    }
}