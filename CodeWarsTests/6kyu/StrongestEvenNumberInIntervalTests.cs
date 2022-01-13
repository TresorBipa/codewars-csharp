using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StrongestEvenNumberInIntervalTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(2, StrongestEvenNumberInInterval.strongestEven(1, 2));
            Assert.AreEqual(8, StrongestEvenNumberInInterval.strongestEven(5, 10));
            Assert.AreEqual(48, StrongestEvenNumberInInterval.strongestEven(48, 56));
            Assert.AreEqual(192, StrongestEvenNumberInInterval.strongestEven(129, 193));
        }
    }
}