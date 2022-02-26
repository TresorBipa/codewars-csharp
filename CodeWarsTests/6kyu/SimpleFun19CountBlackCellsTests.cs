using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun19CountBlackCellsTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun19CountBlackCells();

            Assert.AreEqual(6, SimpleFun19CountBlackCells.CountBlackCells(3, 4));

            Assert.AreEqual(7, SimpleFun19CountBlackCells.CountBlackCells(3, 3));

            Assert.AreEqual(6, SimpleFun19CountBlackCells.CountBlackCells(2, 5));

            Assert.AreEqual(1, SimpleFun19CountBlackCells.CountBlackCells(1, 1));

            Assert.AreEqual(2, SimpleFun19CountBlackCells.CountBlackCells(1, 2));

            Assert.AreEqual(239, SimpleFun19CountBlackCells.CountBlackCells(1, 239));

            Assert.AreEqual(86, SimpleFun19CountBlackCells.CountBlackCells(33, 44));

            Assert.AreEqual(30, SimpleFun19CountBlackCells.CountBlackCells(16, 8));

            Assert.AreEqual(17774, SimpleFun19CountBlackCells.CountBlackCells(6666, 8888));
        }
    }
}