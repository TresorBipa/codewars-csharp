using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun157CountingTrianglesTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun157CountingTriangles();

            Assert.AreEqual(1, kata.CountingTriangles(new int[] {2, 3, 7, 4}));

            Assert.AreEqual(4, kata.CountingTriangles(new int[] {5, 6, 7, 8}));

            Assert.AreEqual(4, kata.CountingTriangles(new int[] {2, 2, 2, 2}));

            Assert.AreEqual(0, kata.CountingTriangles(new int[] {1, 2, 5}));

            Assert.AreEqual(1, kata.CountingTriangles(new int[] {1, 2, 3, 10, 20, 30, 4}));

            Assert.AreEqual(0, kata.CountingTriangles(new int[] {1, 2, 3}));
        }
    }
}