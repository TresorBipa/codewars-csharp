using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MatchingPlatesTests
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual(true,
                MatchingPlates.matchingPlates(
                    new char[] {'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b', 'b'},
                    new char[] {'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b', 'b'}));

            Assert.AreEqual(false,
                MatchingPlates.matchingPlates(
                    new char[] {'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b', 'b'},
                    new char[] {'b', 's', 's', 's', 'b', 's', 'b', 's', 'b', 's', 's', 'b'}));
        }
    }
}