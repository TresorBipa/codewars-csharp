using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OverRoadTests
    {
        [Test]
        public void basic_test_cases()
        {
            Assert.AreEqual(6, OverRoad.overTheRoad(1, 3));
            Assert.AreEqual(4, OverRoad.overTheRoad(3, 3));
            Assert.AreEqual(5, OverRoad.overTheRoad(2, 3));
            Assert.AreEqual(8, OverRoad.overTheRoad(3, 5));
            Assert.AreEqual(16, OverRoad.overTheRoad(7, 11));
        }
    }
}