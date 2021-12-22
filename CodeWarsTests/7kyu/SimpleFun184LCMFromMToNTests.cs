using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun184LCMFromMToNTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun184LCMFromMToN();

            Assert.AreEqual(2, kata.LCMm2n(1, 2));

            Assert.AreEqual(60, kata.LCMm2n(1, 5));

            Assert.AreEqual(60, kata.LCMm2n(5, 1));

            Assert.AreEqual(2520, kata.LCMm2n(1, 10));

            Assert.AreEqual(6, kata.LCMm2n(2, 3));

            Assert.AreEqual(60, kata.LCMm2n(3, 5));

            Assert.AreEqual(232792560, kata.LCMm2n(10, 20));

            Assert.AreEqual(26771144400, kata.LCMm2n(1, 25));

            Assert.AreEqual(600, kata.LCMm2n(24, 25));
        }
    }
}