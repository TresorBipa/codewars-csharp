using CodeWars._6kyu;
using NUnit.Framework;

namespace CodeWarsTests._6kyu
{
    [TestFixture]
    public class ShortestStepsToNumberTests
    {
        [Test]
        public void SimpleTests()
        {
            Assert.AreEqual(0, ShortestStepsToNumber.ShortestStepsToNum(1));
            Assert.AreEqual(4, ShortestStepsToNumber.ShortestStepsToNum(12));
            Assert.AreEqual(4, ShortestStepsToNumber.ShortestStepsToNum(16));
            Assert.AreEqual(9, ShortestStepsToNumber.ShortestStepsToNum(71));
        }
    }
}