using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TVRemoteTests
    {
        [Test]
        public void Example()
        {
            Assert.AreEqual(36, KataTVRemote.TvRemote("codewars"));
        }

        [Test]
        public void Misc()
        {
            Assert.AreEqual(16, KataTVRemote.TvRemote("does"));
            Assert.AreEqual(23, KataTVRemote.TvRemote("your"));
            Assert.AreEqual(33, KataTVRemote.TvRemote("solution"));
            Assert.AreEqual(20, KataTVRemote.TvRemote("work"));
            Assert.AreEqual(12, KataTVRemote.TvRemote("for"));
            Assert.AreEqual(27, KataTVRemote.TvRemote("these"));
            Assert.AreEqual(25, KataTVRemote.TvRemote("words"));
        }
    }
}