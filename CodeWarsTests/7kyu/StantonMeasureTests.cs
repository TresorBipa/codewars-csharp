using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataStantonMeasureTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(3, KataStantonMeasure.StantonMeasure(new int[] {1, 4, 3, 2, 1, 2, 3, 2}));
        }
    }
}