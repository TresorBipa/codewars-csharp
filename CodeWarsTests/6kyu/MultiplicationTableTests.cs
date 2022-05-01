using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataMultiplicationTableTests
    {
        [Test]
        public void MyTest()
        {
            int[,] expected = new int[,] {{1, 2, 3}, {2, 4, 6}, {3, 6, 9}};
            Assert.AreEqual(expected, KataMultiplicationTable.MultiplicationTable(3));
        }
    }
}