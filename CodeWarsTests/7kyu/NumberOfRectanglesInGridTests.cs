using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NumberOfRectanglesInGridTests
    {
        [Test]
        public void Test1()
        {
            int rectangles = NumberOfRectanglesInGrid.NumberOfRectangles(4, 4);
            Assert.AreEqual(100, rectangles);
        }

        [Test]
        public void Test2()
        {
            int rectangles = NumberOfRectanglesInGrid.NumberOfRectangles(5, 5);
            Assert.AreEqual(225, rectangles);
        }
    }
}