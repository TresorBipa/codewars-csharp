using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun13MagicalWellTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun13MagicalWell();

            Assert.AreEqual(8, kata.MagicalWell(1, 2, 2), "");

            Assert.AreEqual(1, kata.MagicalWell(1, 1, 1), "");

            Assert.AreEqual(128, kata.MagicalWell(6, 5, 3), "");
        }
    }
}