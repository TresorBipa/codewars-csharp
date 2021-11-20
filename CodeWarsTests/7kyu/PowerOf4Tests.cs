using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PowerOf4Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, KataPowerOf4.PowerOf4(4));
            Assert.AreEqual(true, KataPowerOf4.PowerOf4(16));
            Assert.AreEqual(false, KataPowerOf4.PowerOf4(1));
            Assert.AreEqual(false, KataPowerOf4.PowerOf4(3.1415));
            Assert.AreEqual(false, KataPowerOf4.PowerOf4("4"));
            Assert.AreEqual(false, KataPowerOf4.PowerOf4(null));
        }
    }
}