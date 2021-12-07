using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun137S2NTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun137S2N();

            Assert.AreEqual(20, kata.S2N(2, 3));

            Assert.AreEqual(434, kata.S2N(3, 5));

            Assert.AreEqual(1762344782, kata.S2N(10, 9));

            Assert.AreEqual(3, kata.S2N(1, 1));

            Assert.AreEqual(1, kata.S2N(0, 0));

            Assert.AreEqual(9090501, kata.S2N(300, 2));

            Assert.AreEqual(61083856, kata.S2N(567, 2));

            Assert.AreEqual(15335280, kata.S2N(37, 4));

            Assert.AreEqual(13409059, kata.S2N(36, 4));
        }
    }
}