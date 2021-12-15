using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun16AppleBoxesTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun16AppleBoxes();

            Assert.AreEqual(-15, kata.AppleBoxes(5));

            Assert.AreEqual(-120, kata.AppleBoxes(15));

            Assert.AreEqual(666, kata.AppleBoxes(36));

            Assert.AreEqual(-1, kata.AppleBoxes(1));
        }
    }
}