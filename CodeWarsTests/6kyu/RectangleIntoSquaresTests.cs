using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RectangleIntoSquaresTests
    {
        [Test]
        public void Test1()
        {
            List<int> r = new List<int> {3, 2, 1, 1};
            Assert.AreEqual(r, RectangleIntoSquares.sqInRect(5, 3));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(null, RectangleIntoSquares.sqInRect(5, 5));
        }
    }
}