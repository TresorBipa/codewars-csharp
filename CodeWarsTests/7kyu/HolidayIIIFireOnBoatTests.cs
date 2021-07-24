using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HolidayIIIFireOnBoatTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Boat Rudder Mast Boat Hull Water ~~ Boat Deck Hull ~~ Propeller Deck ~~ Deck Boat Mast",
                HolidayIIIFireOnBoat.FireFight(
                    "Boat Rudder Mast Boat Hull Water Fire Boat Deck Hull Fire Propeller Deck Fire Deck Boat Mast"));

            Assert.AreEqual("Mast Deck Engine Water ~~", HolidayIIIFireOnBoat.FireFight("Mast Deck Engine Water Fire"));

            Assert.AreEqual("~~ Deck Engine Sail Deck ~~ ~~ ~~ Rudder ~~ Boat ~~ ~~ Captain",
                HolidayIIIFireOnBoat.FireFight(
                    "Fire Deck Engine Sail Deck Fire Fire Fire Rudder Fire Boat Fire Fire Captain"));
        }
    }
}