using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataKnightVsBishopTests
    {
        [Test]
        public void KnightTest()
        {
            object[] bishopPosition = {4, "C"};
            object[] knightPosition = {6, "D"};
            StringAssert.AreEqualIgnoringCase("Knight",
                KataKnightVsBishop.KnightVsBishop(knightPosition, bishopPosition));
        }

        [Test]
        public void BishopTest()
        {
            object[] bishopPosition = {2, "G"};
            object[] knightPosition = {6, "C"};
            StringAssert.AreEqualIgnoringCase("Bishop",
                KataKnightVsBishop.KnightVsBishop(knightPosition, bishopPosition));
        }

        [Test]
        public void NoneTest()
        {
            object[] bishopPosition = {2, "F"};
            object[] knightPosition = {7, "B"};
            StringAssert.AreEqualIgnoringCase("None",
                KataKnightVsBishop.KnightVsBishop(knightPosition, bishopPosition));
        }
    }
}