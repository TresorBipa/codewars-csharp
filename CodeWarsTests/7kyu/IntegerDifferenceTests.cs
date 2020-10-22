using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IntegerDifferenceTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, IntegerDifference.IntDiff(new int[] { 1, 1, 5, 6, 9, 16, 27 }, 4));
            Assert.AreEqual(4, IntegerDifference.IntDiff(new int[] { 1, 1, 3, 3 }, 2));
        }
    }
}