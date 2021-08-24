using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LargestSquareInsideCircleTests
    {
        [Test]
        public void AreaLargestSquareTest()
        {
            LargestSquareInsideCircle.Circle source = new LargestSquareInsideCircle.Circle();

            Assert.AreEqual(50, source.AreaLargestSquare(5));
            Assert.AreEqual(98, source.AreaLargestSquare(7));
            Assert.AreEqual(450, source.AreaLargestSquare(15));
        }
    }
}