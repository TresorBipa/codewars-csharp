using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun109SegmentCoverTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun109SegmentCover();

            Assert.AreEqual(2, kata.SegmentCover(new int[] {1, 3, 4, 5, 8}, 3));

            Assert.AreEqual(3, kata.SegmentCover(new int[] {-7, -2, 0, -1, -6, 7, 3, 4}, 4));

            Assert.AreEqual(3, kata.SegmentCover(new int[] {1, 5, 2, 4, 3}, 1));

            Assert.AreEqual(4, kata.SegmentCover(new int[] {1, 10, 100, 1000}, 1));
        }
    }
}