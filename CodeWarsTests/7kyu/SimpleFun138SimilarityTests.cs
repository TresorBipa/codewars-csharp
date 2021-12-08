using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun138SimilarityTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun138Similarity();

            Assert.AreEqual(1, kata.Similarity(new int[] {1, 2, 3}, new int[] {1, 2, 3}));

            Assert.AreEqual(0, kata.Similarity(new int[] {1, 2, 3}, new int[] {4, 5, 6}));

            Assert.AreEqual(0.5, kata.Similarity(new int[] {1, 2, 4, 6, 7}, new int[] {2, 3, 4, 7}));

            Assert.AreEqual(0.5, kata.Similarity(new int[] {1, 2, 6, 8, 9}, new int[] {0, 1, 4, 5, 6, 8, 9}));

            Assert.AreEqual(0.5, kata.Similarity(new int[] {1, 2, 3, 4, 7, 9}, new int[] {1, 2, 3}));

            Assert.AreEqual(0.3125,
                kata.Similarity(new int[] {0, 1, 3, 4, 5, 6, 9, 14, 15, 16, 17, 18, 19},
                    new int[] {1, 4, 10, 12, 13, 14, 15, 16}));
        }
    }
}