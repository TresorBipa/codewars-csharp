using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MythicalHeadsAndTailsTests
    {
        [Test]
        public void ValidNumbers()
        {
            Assert.AreEqual(new int[] {24, 15}, MythicalHeadsAndTails.Beasts(123, 39));
            Assert.AreEqual(new int[] {23, 65}, MythicalHeadsAndTails.Beasts(371, 88));
            Assert.AreEqual(new int[] {12, 0}, MythicalHeadsAndTails.Beasts(24, 12));
            Assert.AreEqual(new int[] {24, 13}, MythicalHeadsAndTails.Beasts(113, 37));
            Assert.AreEqual(new int[] {90, 91}, MythicalHeadsAndTails.Beasts(635, 181));
        }
    }
}