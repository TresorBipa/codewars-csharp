using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun147FindMissingTreeTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun147FindMissingTree();

            Assert.AreEqual(1, kata.FindTheMissingTree(new int[] {1, 2, 2, 3, 3}));

            Assert.AreEqual(11, kata.FindTheMissingTree(new int[] {11, 2, 3, 3, 3, 11, 2, 2}));

            Assert.AreEqual(76,
                kata.FindTheMissingTree(new int[] {234, 76, 45, 99, 99, 99, 99, 45, 234, 234, 45, 45, 76, 234, 76}));

            Assert.AreEqual(3,
                kata.FindTheMissingTree(new int[] {1, 1, 1, 1, 1, 1, 1, 22, 22, 22, 22, 22, 22, 22, 3, 3, 3, 3, 3, 3}));

            Assert.AreEqual(205, kata.FindTheMissingTree(new int[] {10, 205, 3000, 3000, 10}));

            Assert.AreEqual(50,
                kata.FindTheMissingTree(new int[]
                {
                    50, 408, 50, 50, 50, 50, 408, 408, 408, 680, 408, 680, 50, 408, 680, 50, 50, 680, 408, 680, 50, 680,
                    680, 408, 408, 50, 50, 408, 50, 50, 50, 50, 680, 408, 680, 50, 680, 408, 680, 408, 680, 50, 50, 50,
                    680, 50, 680, 408, 680, 680, 680, 408, 408, 408, 408, 680, 680, 50, 408, 408, 408, 50, 408, 408, 50,
                    680, 680, 680, 50, 680, 680, 680, 50, 680, 408, 50, 50, 408, 50, 408, 680, 408, 50, 680, 680, 408,
                    408, 680, 408
                }));
        }
    }
}