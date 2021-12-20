using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun181RoundingTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun181Rounding();

            Assert.AreEqual(21, kata.Rounding(20, 3));

            Assert.AreEqual(18, kata.Rounding(19, 3));

            Assert.AreEqual(0, kata.Rounding(1, 10));

            Assert.AreEqual(50, kata.Rounding(50, 100));

            Assert.AreEqual(0, kata.Rounding(123, 456));
        }
    }
}