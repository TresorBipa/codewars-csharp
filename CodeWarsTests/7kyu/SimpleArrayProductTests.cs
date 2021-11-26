using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleArrayProductTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(8, SimpleArrayProduct.solve(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } }));
            Assert.AreEqual(45, SimpleArrayProduct.solve(new int[][] { new int[] { 10, -15 }, new int[] { -1, -3 } }));
            Assert.AreEqual(12,
                SimpleArrayProduct.solve(new int[][] { new int[] { -1, 2, -3, 4 }, new int[] { 1, -2, 3, -4 } }));
            Assert.AreEqual(17600,
                SimpleArrayProduct.solve(new int[][]
                    { new int[] { -11, -6 }, new int[] { -20, -20 }, new int[] { 18, -4 }, new int[] { -20, 1 } }));
            Assert.AreEqual(3584,
                SimpleArrayProduct.solve(new int[][]
                    { new int[] { 14, 2 }, new int[] { 0, -16 }, new int[] { -12, -16 } }));
            Assert.AreEqual(12, SimpleArrayProduct.solve(new int[][] { new int[] { -3, -4 }, new int[] { 1, 2, -3 } }));
            Assert.AreEqual(-40,
                SimpleArrayProduct.solve(new int[][]
                    { new int[] { -2, -15, -12, -8, -16 }, new int[] { -4, -15, -7 }, new int[] { -10, -5 } }));
        }
    }
}