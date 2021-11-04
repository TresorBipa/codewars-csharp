using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class VaultExperience1EnoughWaterForHowManyDaysTests
    {
        [Test]
        public void WaterFor37Days()
        {
            Assert.AreEqual(37, VaultExperience1EnoughWaterForHowManyDays.ThirstyIn(150, new int[] {5, 30, 10}));
        }
    }
}