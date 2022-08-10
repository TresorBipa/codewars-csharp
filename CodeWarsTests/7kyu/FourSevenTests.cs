using CodeWars._7kyu;
using NUnit.Framework;

namespace CodeWarsTests._7kyu
{
    [TestFixture]
    public class KataFourSevenTests
    {
        [Test]
        public void CorrectTests()
        {
            Assert.AreEqual(7, KataFourSeven.FourSeven(4));
            Assert.AreEqual(4, KataFourSeven.FourSeven(7));
        }

        [Test]
        public void WrongTests()
        {
            Assert.AreEqual(0, KataFourSeven.FourSeven(100));
            Assert.AreEqual(0, KataFourSeven.FourSeven(-17));
        }
    }
}