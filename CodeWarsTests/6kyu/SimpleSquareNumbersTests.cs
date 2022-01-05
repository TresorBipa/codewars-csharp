using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleSquareNumbersTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(-1, SimpleSquareNumbers.solve(1));
            Assert.AreEqual(-1, SimpleSquareNumbers.solve(2));
            Assert.AreEqual(1, SimpleSquareNumbers.solve(3));
            Assert.AreEqual(-1, SimpleSquareNumbers.solve(4));
            Assert.AreEqual(4, SimpleSquareNumbers.solve(5));
            Assert.AreEqual(9, SimpleSquareNumbers.solve(7));
            Assert.AreEqual(1, SimpleSquareNumbers.solve(8));
            Assert.AreEqual(16, SimpleSquareNumbers.solve(9));
            Assert.AreEqual(-1, SimpleSquareNumbers.solve(10));
            Assert.AreEqual(25, SimpleSquareNumbers.solve(11));
            Assert.AreEqual(36, SimpleSquareNumbers.solve(13));
            Assert.AreEqual(64, SimpleSquareNumbers.solve(17));
            Assert.AreEqual(5428900, SimpleSquareNumbers.solve(88901));
            Assert.AreEqual(429235524, SimpleSquareNumbers.solve(290101));
        }
    }
}