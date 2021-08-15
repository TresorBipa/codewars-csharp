using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HighestPowerOf2ThatEvenlyDividesNumberTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(1, HighestPowerOf2ThatEvenlyDividesNumber.Solution(123));
            Assert.AreEqual(64, HighestPowerOf2ThatEvenlyDividesNumber.Solution(64));
            Assert.AreEqual(8, HighestPowerOf2ThatEvenlyDividesNumber.Solution(132232));
            Assert.AreEqual(64, HighestPowerOf2ThatEvenlyDividesNumber.Solution(192));
        }
    }
}