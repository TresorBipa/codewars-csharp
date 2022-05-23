using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleSumOfPairsTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(0, SimpleSumOfPairs.solve(0));
            Assert.AreEqual(1, SimpleSumOfPairs.solve(1));
            Assert.AreEqual(18, SimpleSumOfPairs.solve(18));
            Assert.AreEqual(11, SimpleSumOfPairs.solve(29));
            Assert.AreEqual(33, SimpleSumOfPairs.solve(1140));
            Assert.AreEqual(68, SimpleSumOfPairs.solve(50000000));
            Assert.AreEqual(144, SimpleSumOfPairs.solve(15569047737));
            Assert.AreEqual(116, SimpleSumOfPairs.solve(2452148459));
        }
    }
}