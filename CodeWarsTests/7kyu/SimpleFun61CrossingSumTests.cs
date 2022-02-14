using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun61CrossingSumTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun61CrossingSum();

            var matrix = new int[][]
            {
                new int[] {1, 1, 1, 1},
                new int[] {2, 2, 2, 2},
                new int[] {3, 3, 3, 3}
            };
            Assert.AreEqual(12, kata.CrossingSum(matrix, 1, 3));

            matrix = new int[][]
            {
                new int[] {1, 1},
                new int[] {3, 3},
                new int[] {1, 1},
                new int[] {2, 2}
            };
            Assert.AreEqual(9, kata.CrossingSum(matrix, 3, 0));

            matrix = new int[][] {new int[] {100}};
            Assert.AreEqual(100, kata.CrossingSum(matrix, 0, 0));
        }
    }
}