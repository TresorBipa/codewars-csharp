using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun63ShapeAreaTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun63ShapeArea();
            Assert.AreEqual(5, kata.ShapeArea(2));
            Assert.AreEqual(13, kata.ShapeArea(3));
            Assert.AreEqual(1, kata.ShapeArea(1));
            Assert.AreEqual(41, kata.ShapeArea(5));
        }
    }
}