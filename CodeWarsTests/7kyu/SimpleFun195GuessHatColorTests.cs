using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun195GuessHatColorTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun195GuessHatColor();

            Assert.AreEqual(2, kata.GuessHatColor("black", "white", "black", "white"));

            Assert.AreEqual(2, kata.GuessHatColor("white", "black", "white", "black"));

            Assert.AreEqual(1, kata.GuessHatColor("white", "black", "black", "white"));
        }
    }
}