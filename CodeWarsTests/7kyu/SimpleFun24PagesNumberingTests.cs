using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun24PagesNumberingTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun24PagesNumbering();

            Assert.AreEqual(5, kata.PagesNumberingWithInk(1, 5));

            Assert.AreEqual(22, kata.PagesNumberingWithInk(21, 5));

            Assert.AreEqual(10, kata.PagesNumberingWithInk(8, 4));

            Assert.AreEqual(23, kata.PagesNumberingWithInk(21, 6));

            Assert.AreEqual(166, kata.PagesNumberingWithInk(76, 250));

            Assert.AreEqual(419, kata.PagesNumberingWithInk(80, 1000));
        }
    }
}