using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun105RectanglesTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun105Rectangles();
            Assert.AreEqual(3, kata.Rectangles(2, 3));
            Assert.AreEqual(1, kata.Rectangles(2, 2));
            Assert.AreEqual(0, kata.Rectangles(1, 1));
            Assert.AreEqual(0, kata.Rectangles(0, 1));
            Assert.AreEqual(9, kata.Rectangles(3, 3));
            Assert.AreEqual(24502500, kata.Rectangles(100, 100));
        }
    }
}