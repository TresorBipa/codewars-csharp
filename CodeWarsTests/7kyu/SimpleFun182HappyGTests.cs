using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun182HappyGTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun182HappyG();

            Assert.AreEqual(true, kata.HappyG("gg0gg3gg0gg"));

            Assert.AreEqual(false, kata.HappyG("gog"));

            Assert.AreEqual(false, kata.HappyG("ggg ggg g ggg"));

            Assert.AreEqual(true, kata.HappyG("A half of a half is a quarter."));

            Assert.AreEqual(false, kata.HappyG("good grief"));

            Assert.AreEqual(true, kata.HappyG("bigger is ggooder"));

            Assert.AreEqual(true, kata.HappyG("gggggggggg"));
        }
    }
}