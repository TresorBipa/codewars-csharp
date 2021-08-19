using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HungarianVowelHarmonyEasyTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("ablaknak", HungarianVowelHarmonyEasy.Dative("ablak"));
            Assert.AreEqual("tükörnek", HungarianVowelHarmonyEasy.Dative("tükör"));
            Assert.AreEqual("keretnek", HungarianVowelHarmonyEasy.Dative("keret"));
            Assert.AreEqual("otthonnak", HungarianVowelHarmonyEasy.Dative("otthon"));
            Assert.AreEqual("virágnak", HungarianVowelHarmonyEasy.Dative("virág"));
            Assert.AreEqual("tettnek", HungarianVowelHarmonyEasy.Dative("tett"));
            Assert.AreEqual("rokkantnak", HungarianVowelHarmonyEasy.Dative("rokkant"));
            Assert.AreEqual("rossznak", HungarianVowelHarmonyEasy.Dative("rossz"));
            Assert.AreEqual("gonosznak", HungarianVowelHarmonyEasy.Dative("gonosz"));
        }
    }
}