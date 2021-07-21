using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FusionChamberShutdownTests
    {
        [Test]
        public void FixedTests()
        {
            Assert.AreEqual((5, 45, 0), FusionChamberShutdown.Burner(45, 11, 100));
            Assert.AreEqual((0, 0, 354), FusionChamberShutdown.Burner(354, 1023230, 0));
            Assert.AreEqual((1, 346, 0), FusionChamberShutdown.Burner(939, 3, 694));
            Assert.AreEqual((20, 215, 0), FusionChamberShutdown.Burner(215, 41, 82100));
            Assert.AreEqual((0, 26, 0), FusionChamberShutdown.Burner(113, 0, 52));
        }
    }
}