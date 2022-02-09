using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun55CyclicStringTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun55CyclicString();

            Assert.AreEqual(3, kata.CyclicString("cabca"));

            Assert.AreEqual(2, kata.CyclicString("aba"));

            Assert.AreEqual(1, kata.CyclicString("ccccccccccc"));

            Assert.AreEqual(4, kata.CyclicString("abaca"));
        }
    }
}