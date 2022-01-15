using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun22IsSmoothTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun22IsSmooth();

            Assert.AreEqual(true, kata.IsSmooth(new int[] {7, 2, 2, 5, 10, 7}));

            Assert.AreEqual(true, kata.IsSmooth(new int[] {-12, 34, 40, -5, -12, 4, 0, 0, -12}));

            Assert.AreEqual(false, kata.IsSmooth(new int[] {-5, -5, 10}));

            Assert.AreEqual(false, kata.IsSmooth(new int[] {4, 2}));

            Assert.AreEqual(false, kata.IsSmooth(new int[] {45, 23, 12, 33, 12, 453, -234, -45}));

            Assert.AreEqual(false, kata.IsSmooth(new int[] {9, 0, 15, 9}));

            Assert.AreEqual(false, kata.IsSmooth(new int[] {-6, 6, -6}));

            Assert.AreEqual(false, kata.IsSmooth(new int[] {26, 26, -17}));

            Assert.AreEqual(false, kata.IsSmooth(new int[] {-7, 5, 5, 10}));

            Assert.AreEqual(false, kata.IsSmooth(new int[] {3, 4, 5}));

            Assert.AreEqual(false, kata.IsSmooth(new int[] {-5, 3, -1, 9}));
        }
    }
}