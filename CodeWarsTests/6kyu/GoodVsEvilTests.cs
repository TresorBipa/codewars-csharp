using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GoodVsEvilTests
    {
        [Test]
        public static void EvilShouldWin()
        {
            Assert.AreEqual("Battle Result: Evil eradicates all trace of Good",
                KataGoodVsEvil.GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1"));
        }

        [Test]
        public static void GoodShouldTriumph()
        {
            Assert.AreEqual("Battle Result: Good triumphs over Evil",
                KataGoodVsEvil.GoodVsEvil("0 0 0 0 0 10", "0 1 1 1 1 0 0"));
        }

        [Test]
        public static void ShouldBeATie()
        {
            Assert.AreEqual("Battle Result: No victor on this battle field",
                KataGoodVsEvil.GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0"));
        }
    }
}