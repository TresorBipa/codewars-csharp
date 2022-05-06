using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PyramidArrayTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[][] { }, PyramidArray.Pyramid(0));
            Assert.AreEqual(new int[][] {new int[] {1}}, PyramidArray.Pyramid(1));
            Assert.AreEqual(new int[][] {new int[] {1}, new int[] {1, 1}}, PyramidArray.Pyramid(2));
            Assert.AreEqual(new int[][] {new int[] {1}, new int[] {1, 1}, new int[] {1, 1, 1}},
                PyramidArray.Pyramid(3));
        }
    }
}