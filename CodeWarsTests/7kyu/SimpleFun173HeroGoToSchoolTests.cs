using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun173HeroGoToSchoolTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun173HeroGoToSchool();

            Assert.AreEqual(0, kata.WhichBusToTake(new string[] {"red", "red", "blue"}, new bool[] {true, true, true}));

            Assert.AreEqual(3,
                kata.WhichBusToTake(new string[] {"blue", "blue", "blue", "red", "red"},
                    new bool[] {false, true, true, true, false}));

            Assert.AreEqual(5,
                kata.WhichBusToTake(new string[] {"blue", "red", "red", "red", "blue", "red", "blue"},
                    new bool[] {true, false, false, false, true, true, false}));

            Assert.AreEqual(3,
                kata.WhichBusToTake(new string[] {"red", "red", "red", "blue"},
                    new bool[] {false, false, false, true}));
        }
    }
}