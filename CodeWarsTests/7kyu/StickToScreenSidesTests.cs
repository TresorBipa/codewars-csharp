using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StickToScreenSidesTests
    {
        [Test]
        public void StickToRight()
        {
            Assert.AreEqual(new[] {100, 23.32}, StickToScreenSides.newCoordinate(100, 50, 10, new[] {91.52, 23.32}));
        }

        [Test]
        public void StickToLeft()
        {
            Assert.AreEqual(new[] {0, 23.32}, StickToScreenSides.newCoordinate(120, 100, 5, new[] {5, 23.32}));
        }

        [Test]
        public void StickToUp()
        {
            Assert.AreEqual(new[] {91.52, 100}, StickToScreenSides.newCoordinate(200, 100, 20, new[] {91.52, 81.32}));
        }

        [Test]
        public void StickToDown()
        {
            Assert.AreEqual(new[] {21.52, 0}, StickToScreenSides.newCoordinate(40, 20, 3, new[] {21.52, 2.99}));
        }

        [Test]
        public void OutOfScreen()
        {
            Assert.AreEqual(new[] {0, 0}, StickToScreenSides.newCoordinate(1000, 700, 10, new[] {-0.01, 23.32}));
        }
    }
}