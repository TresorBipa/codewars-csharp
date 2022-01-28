using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun45NewNumeralSystemTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun45NewNumeralSystem();

            Assert.AreEqual(new string[] {"A + G", "B + F", "C + E", "D + D"}, kata.NewNumeralSystem('G'));

            Assert.AreEqual(new string[] {"A + A"}, kata.NewNumeralSystem('A'));

            Assert.AreEqual(new string[] {"A + D", "B + C"}, kata.NewNumeralSystem('D'));

            Assert.AreEqual(new string[] {"A + E", "B + D", "C + C"}, kata.NewNumeralSystem('E'));

            Assert.AreEqual(new string[] {"A + O", "B + N", "C + M", "D + L", "E + K", "F + J", "G + I", "H + H"},
                kata.NewNumeralSystem('O'));
        }
    }
}