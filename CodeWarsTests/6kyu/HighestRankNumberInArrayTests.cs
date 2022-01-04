using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HighestRankNumberInArrayTests
    {
        [Test]
        public void BasicTest()
        {
            var arr = new int[] {12, 10, 8, 12, 7, 6, 4, 10, 12};
            Assert.AreEqual(12, HighestRankNumberInArray.HighestRank(arr));
        }
    }
}