using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun35DifferentSquaresTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun35DifferentSquares();

            var matrix = new int[][]
            {
                new int[] {1, 2, 1},
                new int[] {2, 2, 2},
                new int[] {2, 2, 2},
                new int[] {1, 2, 3},
                new int[] {2, 2, 1}
            };
            Assert.AreEqual(6, kata.DifferentSquares(matrix));

            matrix = new int[][]
            {
                new int[] {9, 9, 9, 9, 9},
                new int[] {9, 9, 9, 9, 9},
                new int[] {9, 9, 9, 9, 9}
            };
            Assert.AreEqual(1, kata.DifferentSquares(matrix));

            matrix = new int[][] {new int[] {3}};
            Assert.AreEqual(0, kata.DifferentSquares(matrix));

            matrix = new int[][] {new int[] {3, 4, 5, 6, 7, 8, 9}};
            Assert.AreEqual(0, kata.DifferentSquares(matrix));

            matrix = new int[][]
            {
                new int[] {3},
                new int[] {4},
                new int[] {5},
                new int[] {6},
                new int[] {7}
            };
            Assert.AreEqual(0, kata.DifferentSquares(matrix));
        }
    }
}