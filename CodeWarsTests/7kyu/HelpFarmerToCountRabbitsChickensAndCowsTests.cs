using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HelpFarmerToCountRabbitsChickensAndCowsTests
    {
        [Test]
        public void BasicTests()
        {
            var expected = new Dictionary<string, int>()
            {
                {"rabbits", 3},
                {"chickens", 5},
                {"cows", 3}
            };
            Assert.AreEqual(expected, HelpFarmerToCountRabbitsChickensAndCows.get_animals_count(34, 11, 6));

            expected = new Dictionary<string, int>()
            {
                {"rabbits", 30},
                {"chickens", 7},
                {"cows", 5}
            };
            Assert.AreEqual(expected, HelpFarmerToCountRabbitsChickensAndCows.get_animals_count(154, 42, 10));
        }
    }
}